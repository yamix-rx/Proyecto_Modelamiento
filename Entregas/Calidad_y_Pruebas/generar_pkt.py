"""Genera el laboratorio N=28 de Farmacia Sanet en Cisco Packet Tracer."""
from pathlib import Path
from collections import Counter
import pktlib

dest=Path("Entregas/Calidad_y_Pruebas/Topologia_Calidad_Farmacia_Sanet_N28.pkt")
dest.parent.mkdir(parents=True,exist_ok=True)
n=pktlib.new()
r=n.router("R1","2911",at=(1060,100))
a=n.switch("SW1","2960-24TT",at=(510,270))
b=n.switch("SW2","2960-24TT",at=(1600,270))
r["g0/0"].connect(a["g0/1"])
a["g0/2"].connect(b["g0/1"])

names={10:"VENTAS",20:"INVENTARIO_COMPRAS",30:"ADMINISTRACION",40:"REPORTES",50:"SERVIDORES"}
for sw in (a,b):
    sw.config("hostname "+sw.name+"\nno ip domain-lookup")
    for vid,title in names.items():
        sw.config(f"vlan {vid}\n name {title}")
    sw.config("interface GigabitEthernet0/1\n description TRONCAL_UPLINK\n switchport mode trunk\n switchport trunk allowed vlan 10,20,30,40,50")
a.config("interface GigabitEthernet0/2\n description TRONCAL_A_SW2\n switchport mode trunk\n switchport trunk allowed vlan 10,20,30,40,50")

rc=["hostname R1", "no ip domain-lookup", "interface GigabitEthernet0/0", " description TRONCAL_A_SW1", " no ip address", " no shutdown"]
for vid,area in names.items():
    rc += [f"interface GigabitEthernet0/0.{vid}", f" description GATEWAY_{area}",f" encapsulation dot1Q {vid}",f" ip address 192.168.{vid}.1 255.255.255.0"]
r.config("\n".join(rc))

group=Counter()
for i in range(1,27):
    vid=10 if i<=8 else 20 if i<=15 else 30 if i<=21 else 40
    group[vid]+=1
    ip=f"192.168.{vid}.{10+group[vid]}"
    sw=a if i<=14 else b
    port=i if i<=14 else i-14
    ix=(i-1 if i<=14 else i-15)
    x=(85 if i<=14 else 1205)+(ix%7)*145
    y=500+(ix//7)*170
    hostname=f"PC-{i:02d}"
    pc=n.pc(hostname,at=(x,y),ip=ip+"/24",gateway=f"192.168.{vid}.1")
    pc["fa0"].connect(sw[f"fa0/{port}"])
    sw.config(f"interface FastEthernet0/{port}\n description {hostname}_{names[vid]}\n switchport mode access\n switchport access vlan {vid}\n spanning-tree portfast")
for i in (1,2):
    ip=f"192.168.50.{10+i}"
    srv=n.server(f"SRV-{i}",at=(1430+(i-1)*250,940),ip=ip+"/24",gateway="192.168.50.1")
    port=12+i
    srv["fa0"].connect(b[f"fa0/{port}"])
    b.config(f"interface FastEthernet0/{port}\n description SRV-{i}_SERVIDORES\n switchport mode access\n switchport access vlan 50\n spanning-tree portfast")

n.note("FARMACIA SANET - N=28 EQUIPOS TERMINALES | 26 PCS + 2 SERVIDORES | 5 VLAN",(520,-35))
n.note("R1: INTER-VLAN 802.1Q",(1190,100))
n.note("SW1: 14 PCS / TRONCALES G0/1 A R1 Y G0/2 A SW2",(160,350))
n.note("SW2: 12 PCS Y 2 SERVIDORES / TRONCAL G0/1 A SW1",(1250,350))
n.note("VLAN 10: VENTAS 8 | VLAN 20: INVENTARIO 7 | VLAN 30: ADMIN 6 | VLAN 40: REPORTES 5 | VLAN 50: SERVIDORES 2",(280,1100))
n.note("PRUEBAS: show vlan brief | show interfaces trunk | show ip interface brief | ping 192.168.50.11",(350,1175))
n.save(dest)
assert len(n.devices)==31 and len(n.links)==30
print(dest,dest.stat().st_size,"bytes")
