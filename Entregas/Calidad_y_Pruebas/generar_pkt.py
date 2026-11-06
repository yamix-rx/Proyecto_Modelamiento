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


# Colores suaves de fondo y contornos bien visibles por VLAN
vlan_colors = {
    10: ("#1976D2","#E7F2FF","VENTAS Y CAJA"),
    20: ("#2E7D32","#EAF7EA","INVENTARIO Y COMPRAS"),
    30: ("#7B1FA2","#F3E7FC","ADMINISTRACION / USUARIOS / CATALOGOS"),
    40: ("#E65100","#FFF0DD","REPORTES Y CONSULTAS"),
    50: ("#C62828","#FDE8E7","SERVIDORES DE APLICACION Y BD"),
}

def panel(vlan, box, etiqueta):
    x1,y1,x2,y2=box
    borde,relleno,area=vlan_colors[vlan]
    n.rectangle(x1,y1,x2,y2,outline=borde,fill=relleno)
    n.note(f"VLAN {vlan} - {area} | {etiqueta}",(x1+30,y1+18))

# VLAN 20 se muestra en dos paneles verdes porque ocupa ambos switches.
panel(10,(55,465,1030,870),"8 PC - SW1")
panel(20,(55,930,1030,1310),"6 PC - SW1")
panel(20,(1090,465,1540,685),"1 PC - SW2")
panel(50,(1580,465,2075,685),"2 SERVIDORES - SW2")
panel(30,(1090,745,2075,1045),"6 PC - SW2")
panel(40,(1090,1115,2075,1415),"5 PC - SW2")

# Solo cambian coordenadas para agrupar visualmente; no se altera ninguna conexión ni configuración.
r.xy=(1080,100)
a.xy=(540,290)
b.xy=(1645,290)
def pc_xy(i):
    if i<=8:
        j=i-1
        return 165+(j%4)*235,590+(j//4)*185
    if i<=14:
        j=i-9
        return 250+(j%3)*300,1040+(j//3)*160
    if i==15: return 1300,575
    if i<=21:
        j=i-16
        return 1260+(j%3)*300,835+(j//3)*135
    j=i-22
    return 1260+(j%3)*300,1205+(j//3)*135

for i in range(1,27):
    n.device(f"PC-{i:02d}").xy=pc_xy(i)
n.device("SRV-1").xy=(1690,580)
n.device("SRV-2").xy=(1915,580)

n.note("FARMACIA SANET - N=28 TERMINALES | 26 PC + 2 SERVIDORES | 5 VLAN",(520,10))
n.note("R1 - ENRUTAMIENTO INTER-VLAN 802.1Q",(1240,95))
n.note("SW1: 14 PC | G0/1: TRONCAL A R1 | G0/2: TRONCAL A SW2",(155,355))
n.note("SW2: 12 PC + 2 SERVIDORES | G0/1: TRONCAL A SW1",(1265,355))
n.note("COLORES: VLAN 10 AZUL | VLAN 20 VERDE | VLAN 30 MORADO | VLAN 40 NARANJA | VLAN 50 ROJO",(300,1525))
n.note("PRUEBAS: show vlan brief | show interfaces trunk | ping desde PC-01 a 192.168.50.11",(315,1590))

n.save(dest)
assert len(n.devices)==31 and len(n.links)==30
print(dest,dest.stat().st_size,"bytes")
