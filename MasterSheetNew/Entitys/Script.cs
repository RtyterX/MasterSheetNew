using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Entitys
{
    internal class Script
    {
        public string name;
        public string scriptString;

        public Script(string Name, string ScriptString)
        {
            name = Name;
            scriptString = ScriptString;
        }


        public List<Script> AddScripts()
        {
            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- CONFIG  --------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Config - Cisco - BLD -------------------------------------------------------
            string ciscoBLDsemVlan = "conf t \r\n" +
                "!\r\n" +
                "!\r\n" +
                "hostname var0 \r\n" +
                "!\r\n" +
                "ip domain name embratel \r\n" +
                "!\r\n" +
                "!\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DE USUARIO # \r\n" +
                "###################################################### \r\n" +
                "!\r\n" +
                "service password-encryption\r\n" +
                "username EBT privilege 10 password CQMR\r\n" +
                "enable secret PRO1AN\r\n" +
                "logging buffered 4096 debugging\r\n" +
                "service tcp-keepalives-in\r\n" +
                "service tcp-keepalives-out\r\n" +
                "no enable password\r\n" +
                "service timestamps debug datetime msec localtime show-timezone\r\n" +
                "service timestamps log datetime msec localtime show-timezone\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# LIMPEZA \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "no ip domain name yourdomain.com\r\n" +
                "no ip domain lookup\r\n" +
                "!\r\n" +
                "!\r\n" +
                "logging buffered 51200 warnings\r\n" +
                "no logging console\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no boot host\r\n" +
                "no boot network \r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip finger\r\n" +
                "no service pad\r\n" +
                "no service tcp-small-servers\r\n" +
                "no ip bootp server\r\n" +
                "no ip source-route\r\n" +
                "no cdp run\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no access-list 23 permit 10.10.10.0 0.0.0.7\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip http server\r\n" +
                "no ip http access-class 23\r\n" +
                "no ip http authentication local\r\n" +
                "no ip http secure-server\r\n" +
                "no ip http timeout-policy idle 60 life 86400 requests 10000\r\n" +
                "no logging trap notifications\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip dhcp excluded-address 10.10.10.1\r\n" +
                "no ip dhcp pool ccp-pool\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no ip ssh version 1\r\n" +
                "ip ssh version 2\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki trustpoint TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "yes \r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki certificate chain TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "crypto pki token default removal timeout 0\r\n" +
                "!\r\n" +
                "no crypto key generate rsa\r\n" +
                "crypto key generate rsa\r\n" +
                "y\r\n" +
                "1024\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# BLOQUEIO - ACCESS LIST \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ip access-list extended BLOQUEIO_TELNET\r\n" +
                "remark IP LOOPBACK PE\r\n" +
                "permit ip host var10 any\r\n" +
                "permit ip any host var10\r\n" +
                "!\r\n" +
                "remark IP PE - CCTO\r\n" +
                "permit ip host var7 any\r\n" +
                "permit ip any host var7\r\n" +
                "!\r\n" +
                "remark IP GERENCIA GCPE\r\n" +
                "permit ip any 200.255.156.192 0.0.0.63\r\n" +
                "permit ip 200.255.156.192 0.0.0.63 any\r\n" +
                "!\r\n" +
                "!\r\n" +
                "line vty 0 4 \r\n" +
                "access-class BLOQUEIO_TELNET in\r\n" +
                "access-class BLOQUEIO_TELNET out\r\n" +
                "exec-timeout 15 0\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# POLICY MAP - QoS \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "policy-map SHAPE_OUT\r\n" +
                "class class-default\r\n" +
                " shape average var2000\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# CONFIGURACOES DE INTERFACES \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "interface var3\r\n" +
                " description var1\r\n" +
                " bandwidth var3\r\n" +
                " service-policy output SHAPE_OUT\r\n" +
                " no shut\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "interface var5\r\n" +
                " description ** LAN **\r\n" +
                " ip address var9 mascara\r\n" +
                " no ip redirects\r\n" +
                " no ip unreachables\r\n" +
                " no ip proxy-arp\r\n" +
                " duplex auto\r\n" +
                " speed auto\r\n" +
                " no shutdown\r\n" +
                " no cdp enable\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ip route 0.0.0.0 0.0.0.0 var7\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# CONFIGURACOES DE SNMP \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "snmp-server community LIDER RO\r\n" +
                "snmp-server host 200.255.156.194 LIDER\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DO RELOGIO INTERNO \r\n" +
                "###################################################### \r\n" +
                "!\r\n" +
                "clock timezone BR -3 0\r\n" +
                "clock summer-time BR recurring 1 Sun Oct 0:00 3 Sun Feb 0:00\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \n" +
                "!# CONFIGURACOES DE NTP \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ntp server 200.20.186.75 prefer source var3\r\n" +
                "ntp server 200.20.186.94 source var3\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# BANNER - USER INTERFACE \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "!\r\n" +
                "banner motd ^C\r\n" +
                "||========================================||  \r\n" +
                "||========== CLARO Brasil S.A. ===========||  \r\n" +
                "||========================================||  \r\n" +
                "                                              \r\n" +
                "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
                "           AUTHORIZED USERS ONLY              \r\n" +
                "                                              \r\n" +
                "        OS ACESSOS SERAO MONITORADOS          \r\n" +
                "         ACCESSES WILL BE MONITORED           \r\n" +
                "                                              \r\n" +
                "||========================================||^ \r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no banner exec ^C\r\n" +
                "no banner login ^C\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "line con 0\r\n" +
                "no password\r\n" +
                "exec-timeout 15 0\r\n" +
                "login local\r\n" +
                "line aux 0\r\n" +
                "no password\r\n" +
                "login local\r\n" +
                "transport input none\r\n" +
                "line vty 0 4\r\n" +
                "no password\r\n" +
                "exec-timeout 15 0\r\n" +
                "login local\r\n" +
                "transport input telnet ssh\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "end\r\n";

            // ------------------------------

            string ciscoBLDcomVlan = "conf t \r\n" +
            "!\r\n" +
            "!\r\n" +
            "hostname var0\r\n" +
            "!\r\n" +
            "ip domain name embratel \r\n" +
            "!\r\n" +
            "!\r\n" +
            "###################################################### \r\n" +
            "# CONFIGURACOES DE USUARIO # \r\n" +
            "###################################################### \r\n" +
            "!\r\n" +
            "service password-encryption\r\n" +
            "username EBT privilege 10 password CQMR\r\n" +
            "enable secret PRO1AN\r\n" +
            "logging buffered 4096 debugging\r\n" +
            "service tcp-keepalives-in\r\n" +
            "service tcp-keepalives-out\r\n" +
            "no enable password\r\n" +
            "service timestamps debug datetime msec localtime show-timezone\r\n" +
            "service timestamps log datetime msec localtime show-timezone\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# LIMPEZA \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "no ip domain name yourdomain.com\r\n" +
            "no ip domain lookup\r\n" +
            "!\r\n" +
            "!\r\n" +
            "logging buffered 51200 warnings\r\n" +
            "no logging console\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no boot host\r\n" +
            "no boot network \r\n" +
            "!\r\n" +
            "!\r\n" +
            "no ip finger\r\n" +
            "no service pad\r\n" +
            "no service tcp-small-servers\r\n" +
            "no ip bootp server\r\n" +
            "no ip source-route\r\n" +
            "no cdp run\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no access-list 23 permit 10.10.10.0 0.0.0.7\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no ip http server\r\n" +
            "no ip http access-class 23\r\n" +
            "no ip http authentication local\r\n" +
            "no ip http secure-server\r\n" +
            "no ip http timeout-policy idle 60 life 86400 requests 10000\r\n" +
            "no logging trap notifications\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no ip dhcp excluded-address 10.10.10.1\r\n" +
            "no ip dhcp pool ccp-pool\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no ip ssh version 1\r\n" +
            "ip ssh version 2\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no crypto pki trustpoint TP-self-signed-4256465151\r\n" +
            "!\r\n" +
            "yes \r\n" +
            "!\r\n" +
            "!\r\n" +
            "no crypto pki certificate chain TP-self-signed-4256465151\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "crypto pki token default removal timeout 0\r\n" +
            "!\r\n" +
            "no crypto key generate rsa\r\n" +
            "crypto key generate rsa\r\n" +
            "y\r\n" +
            "1024\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# BLOQUEIO - ACCESS LIST \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "ip access-list extended BLOQUEIO_TELNET\r\n" +
            "remark IP LOOPBACK PE\r\n" +
            "permit ip host var10 any\r\n" +
            "permit ip any host var10\r\n" +
            "!\r\n" +
            "remark IP PE - CCTO\r\n" +
            "permit ip host var7 any\r\n" +
            "permit ip any host var7\r\n" +
            "!\r\n" +
            "remark IP GERENCIA GCPE\r\n" +
            "permit ip any 200.255.156.192 0.0.0.63\r\n" +
            "permit ip 200.255.156.192 0.0.0.63 any\r\n" +
            "!\r\n" +
            "!\r\n" +
            "line vty 0 4 \r\n" +
            "access-class BLOQUEIO_TELNET in\r\n" +
            "access-class BLOQUEIO_TELNET out\r\n" +
            "exec-timeout 15 0\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# POLICY MAP - QoS \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "policy-map SHAPE_OUT\r\n" +
            "class class-default\r\n" +
            " shape average var2000\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# CONFIGURACOES DE INTERFACES \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "interface var3\r\n" +
            " description var1\r\n" +
            " bandwidth var2\r\n" +
            " service-policy output SHAPE_OUT\r\n" +
            " no shut\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "interface var3.var4\r\n" +
            "description var1\r\n" +
            "bandwidth var2\r\n" +
            "encapsulation dot1Q var4\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "interface var5\r\n" +
            " description ** LAN **\r\n" +
            " ip address var9 mascara\r\n" +
            " no ip redirects\r\n" +
            " no ip unreachables\r\n" +
            " no ip proxy-arp\r\n" +
            " duplex auto\r\n" +
            " speed auto\r\n" +
            " no shutdown\r\n" +
            " no cdp enable\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# ROTA ESTATICA \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "ip route 0.0.0.0 0.0.0.0 var7\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# CONFIGURACOES DE SNMP \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "snmp-server community LIDER RO\r\n" +
            "snmp-server host 200.255.156.194 LIDER\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "###################################################### \r\n" +
            "# CONFIGURACOES DO RELOGIO INTERNO \r\n" +
            "###################################################### \r\n" +
            "!\r\n" +
            "clock timezone BR -3 0\r\n" +
            "clock summer-time BR recurring 1 Sun Oct 0:00 3 Sun Feb 0:00\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \n" +
            "!# CONFIGURACOES DE NTP \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "ntp server 200.20.186.75 prefer source var3 var4\r\n" +
            "ntp server 200.20.186.94 source var3 var4\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!###################################################### \r\n" +
            "!# BANNER - USER INTERFACE \r\n" +
            "!###################################################### \r\n" +
            "!\r\n" +
            "!\r\n" +
            "banner motd ^C\r\n" +
            "||========================================||  \r\n" +
            "||========== CLARO Brasil S.A. ===========||  \r\n" +
            "||========================================||  \r\n" +
            "                                              \r\n" +
            "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
            "           AUTHORIZED USERS ONLY              \r\n" +
            "                                              \r\n" +
            "        OS ACESSOS SERAO MONITORADOS          \r\n" +
            "         ACCESSES WILL BE MONITORED           \r\n" +
            "                                              \r\n" +
            "||========================================||^ \r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "no banner exec ^C\r\n" +
            "no banner login ^C\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "line con 0\r\n" +
            "no password\r\n" +
            "exec-timeout 15 0\r\n" +
            "login local\r\n" +
            "line aux 0\r\n" +
            "no password\r\n" +
            "login local\r\n" +
            "transport input none\r\n" +
            "line vty 0 4\r\n" +
            "no password\r\n" +
            "exec-timeout 15 0\r\n" +
            "login local\r\n" +
            "transport input telnet ssh\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "!\r\n" +
            "end\r\n";


            // ------------------------------------------- Config - HPE - BLD -------------------------------------------------------

            string hpeBLDcomVlan = "#\r\nsystem-view\r\n#\r\n#\r\nsysname var0\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE USUARIO # \r\n###################################################### \r\n#\r\nlocal-user EBT class manage\r\npassword simple PRO1AN\r\nPRO1AN\r\nservice-type telnet\r\nservice-type telnet terminal\r\n service-type ftp\r\n authorization-attribute user-role network-admin\r\n authorization-attribute user-role network-operator\r\ntelnet server enable\r\npassword-recovery enable\r\ninfo-center logbuffer size 1024\r\n#\r\n#\r\n#\r\n###################################################### \r\n# LIMPEZA # \r\n###################################################### \r\n#\r\nundo local-user admin class manage\r\n#\r\n#\r\nundo dns proxy enable\r\n#\r\n#\r\ninterface GigabitEthernet0/0\r\nundo ip address dhcp-alloc\r\n#\r\n#\r\nundo dhcp server ip-pool lan1\r\nundo dhcp enable\r\nundo dhcp server always-broadcast\r\n#\r\n#\r\nundo interface Vlan-interface1\r\n#\r\n#\r\nundo ip http enable\r\n#\r\n#\r\nundo nqa entry imclinktopologypleaseignore ping\r\nundo nqa schedule imclinktopologypleaseignore ping\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE INTERFACES # \r\n###################################################### \r\n#\r\ninterface var3\r\nport link-mode route\r\nundo virtualbaudrate\r\ndescription var1\r\nbandwidth var2\r\nqos gts any cir var2\r\n#\r\n#\r\n#\r\ninterface var3.var4\r\ndescription var1\r\nbandwidth var2\r\nvlan-type dot1q vid var4\r\n#\r\n#\r\n#\r\ninterface var5\r\nport link-mode route\r\ny\r\ndescription ** LAN **\r\nip address var9 mascaraLAN\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# ROTA ESTATICA # \r\n###################################################### \r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var7\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BLOQUEIO - ACCESS LIST # \r\n###################################################### \r\n#\r\nacl advanced 3000\r\n#\r\nrule 5 permit ip source  0\r\nrule 10 permit ip destination  0\r\nrule 10 comment IP LOOPBACK PE\r\n#\r\nrule 15 permit ip source var7 0\r\nrule 20 permit ip destination var7 0\r\nrule 20 comment IP PE - CCTO\r\n#\r\nrule 25 permit ip destination 200.255.156.192 0.0.0.63\r\nrule 30 permit ip source 200.255.156.192 0.0.0.63\r\nrule 30 comment IP GERENCIA GCPE\r\n#\r\n#\r\ntelnet server acl 3000\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE SNMP \r\n###################################################### \r\n#\r\nsnmp-agent community read LIDER\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DO RELOGIO INTERNO \r\n###################################################### \r\n# \r\nclock timezone BR minus 03:00:00\r\n#\r\n#\r\n#\r\n###################################################### \r\n# NTP PARA OS SERVIDORES NTP DO OBSERVATORIO NACIONAL \r\n###################################################### \r\n#\r\nntp-service enable\r\nntp-service unicast-server 200.20.186.75 priority source var5\r\nntp-service unicast-server 200.20.186.94 source var5\r\nntp-service refclock-master 12\r\n#\r\nclock protocol ntp\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIG PARA HABILITAR O SSH \r\n###################################################### \r\n#\r\nlocal-user EBT\r\n service-type telnet terminal ssh\r\n#\r\n#\r\npublic-key local create rsa\r\ny\r\n1024\r\n#\r\n#\r\nssh server enable\r\nssh server acl 3000\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BANNER - USER INTERFACE \r\n###################################################### \r\n#\r\nuser-interface con 0\r\n authentication-mode scheme\r\nuser-interface tty 13\r\nuser-interface aux 0\r\n authentication-mode scheme\r\nuser-interface vty 0 4\r\n authentication-mode scheme\r\n#\r\n#\r\nheader motd %\r\n||========================================|| \r\n||===========CLARO Brasil S.A.============|| \r\n||========================================|| \r\n                                             \r\n        SOMENTE USUARIOS AUTORIZADOS         \r\n           AUTHORIZED USERS ONLY             \r\n                                             \r\n        OS ACESSOS SERAO MONITORADOS         \r\n         ACCESSES WILL BE MONITORED          \r\n                                             \r\n||========================================|| \r\n%\r\n#\r\n#\r\n#\r\nreturn\r\n#\r\n\r\n";

            string hpeBLDsemVlan = "#\r\nsystem-view\r\n#\r\n#\r\nsysname var0\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE USUARIO # \r\n###################################################### \r\n#\r\nlocal-user EBT class manage\r\npassword simple PRO1AN\r\nPRO1AN\r\nservice-type telnet\r\nservice-type telnet terminal\r\n service-type ftp\r\n authorization-attribute user-role network-admin\r\n authorization-attribute user-role network-operator\r\ntelnet server enable\r\npassword-recovery enable\r\ninfo-center logbuffer size 1024\r\n#\r\n#\r\n#\r\n###################################################### \r\n# LIMPEZA # \r\n###################################################### \r\n#\r\nundo local-user admin class manage\r\n#\r\n#\r\nundo dns proxy enable\r\n#\r\n#\r\ninterface GigabitEthernet0/0\r\nundo ip address dhcp-alloc\r\n#\r\n#\r\nundo dhcp server ip-pool lan1\r\nundo dhcp enable\r\nundo dhcp server always-broadcast\r\n#\r\n#\r\nundo interface Vlan-interface1\r\n#\r\n#\r\nundo ip http enable\r\n#\r\n#\r\nundo nqa entry imclinktopologypleaseignore ping\r\nundo nqa schedule imclinktopologypleaseignore ping\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE INTERFACES # \r\n###################################################### \r\n#\r\ninterface var3\r\nport link-mode route\r\nundo virtualbaudrate\r\ndescription var1\r\nbandwidth var2\r\nqos gts any cir var2\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\ninterface var5\r\nport link-mode route\r\ny\r\ndescription ** LAN **\r\nip address var9 mascaraLAN\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# ROTA ESTATICA # \r\n###################################################### \r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var7\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BLOQUEIO - ACCESS LIST # \r\n###################################################### \r\n#\r\nacl advanced 3000\r\n#\r\nrule 5 permit ip source var10 0\r\nrule 10 permit ip destination var10 0\r\nrule 10 comment IP LOOPBACK PE\r\n#\r\nrule 15 permit ip source var7 0\r\nrule 20 permit ip destination var7 0\r\nrule 20 comment IP PE - CCTO\r\n#\r\nrule 25 permit ip destination 200.255.156.192 0.0.0.63\r\nrule 30 permit ip source 200.255.156.192 0.0.0.63\r\nrule 30 comment IP GERENCIA GCPE\r\n#\r\n#\r\ntelnet server acl 3000\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE SNMP \r\n###################################################### \r\n#\r\nsnmp-agent community read LIDER\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DO RELOGIO INTERNO \r\n###################################################### \r\n# \r\nclock timezone BR minus 03:00:00\r\n#\r\n#\r\n#\r\n###################################################### \r\n# NTP PARA OS SERVIDORES NTP DO OBSERVATORIO NACIONAL \r\n###################################################### \r\n#\r\nntp-service enable\r\nntp-service unicast-server 200.20.186.75 priority source var5\r\nntp-service unicast-server 200.20.186.94 source var5\r\nntp-service refclock-master 12\r\n#\r\nclock protocol ntp\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIG PARA HABILITAR O SSH \r\n###################################################### \r\n#\r\nlocal-user EBT\r\n service-type telnet terminal ssh\r\n#\r\n#\r\npublic-key local create rsa\r\ny\r\n1024\r\n#\r\n#\r\nssh server enable\r\nssh server acl 3000\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BANNER - USER INTERFACE \r\n###################################################### \r\n#\r\nuser-interface con 0\r\n authentication-mode scheme\r\nuser-interface tty 13\r\nuser-interface aux 0\r\n authentication-mode scheme\r\nuser-interface vty 0 4\r\n authentication-mode scheme\r\n#\r\n#\r\nheader motd %\r\n||========================================|| \r\n||===========CLARO Brasil S.A.============|| \r\n||========================================|| \r\n                                             \r\n        SOMENTE USUARIOS AUTORIZADOS         \r\n           AUTHORIZED USERS ONLY             \r\n                                             \r\n        OS ACESSOS SERAO MONITORADOS         \r\n         ACCESSES WILL BE MONITORED          \r\n                                             \r\n||========================================|| \r\n%\r\n#\r\n#\r\n#\r\nreturn\r\n#\r\n\r\n";


            // ------------------------------------------- Config - Fortigate - BLD --------------------------------------------------

            string fortigateBLDsemVLAN = "# \r\n# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n#\r\n################# Configs - Hostname/Horario ############# \r\n#\r\nconfig system global\r\n    set hostname \"var0\"\r\n   set timezone 18\r\n   set dst disable\r\nend\r\n#\r\n#\r\n################# Deleta DHCP na LAN ################# \r\n#\r\nconfig system dhcp server\r\n   delete 1\r\n   delete 2\r\nend\r\n#\r\n#\r\n################# Limpar Firewall Policy ######################## \r\n#\r\nconfig firewall policy\r\n    purge\r\n    y\r\nend\r\n#\r\n#\r\n################# Remove as Interfaces do Virtual-Switch ############ \r\n# \r\nconfig system virtual-switch\r\n    edit lan\r\n        set physical-switch \"sw0\"\r\n        config port\r\n            delete lan1\r\n            delete lan2\r\n            delete lan3\r\n            #\r\n        end\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n############## Limpeza Interface LAN ##################### \r\n# \r\nconfig system interface\r\n    edit lan\r\n       unset ip\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################# Config - BANER ################ \r\n#\r\nconfig system replacemsg admin pre_admin-disclaimer-text\r\nset buffer \"\r\n||========================================||  \r\n||========== CLARO Brasil S.A. ===========||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\nend\r\nconfig system global\r\n     set pre-login-banner enable\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Usuário/Trusthost ################### \r\n#\r\nconfig system admin\r\n    edit \"EBT\"\r\n       set accprofile \"super_admin\"\r\n       set vdom \"root\"\r\n       set password PRO1AN\r\n       set trusthost1 169.248.255.254 255.255.255.255\r\n       set trusthost2 200.255.156.192 255.255.255.192\r\n       set trusthost3 200.255.122.0 255.255.255.0\r\n       set trusthost5 200.244.28.61 255.255.255.255\r\n       set trusthost6 200.244.27.26 255.255.255.255\r\n       set trusthost7 var7 255.255.255.255\r\n       set trusthost8 var10 255.255.255.255\r\n       set accprofile \"super_admin\"\r\n    next\r\n#\r\n    delete \"admin\"\r\nend\r\n#\r\n#\r\n#\r\n################# Config - NTP Embratel ################ \r\n#\r\nconfig system ntp\r\n    set ntpsync enable\r\n    set type custom\r\n    set syncinterval 1\r\n    config ntpserver\r\n        edit 0\r\n            set server \"200.20.186.75\"\r\n            set server \"200.20.186.94\"\r\n        next\r\n    end\r\n    set server-mode enable\r\n    set interface \"fortilink\"\r\nend\r\n#\r\n#\r\n#\r\n################# Config - SNMP Embratel ################### \r\n#\r\nconfig system snmp community\r\n    edit 0\r\n    set name \"LIDER RO\"\r\n    config hosts\r\n      edit 0\r\n        set ip 200.255.156.194 255.255.255.255\r\n      next\r\n    end\r\n    next\r\n    end\r\n    config system snmp sysinfo\r\n      set status enable\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Interfaces LAN / WAN ############### \r\n#\r\nconfig system interface \r\n#\r\n#\r\n################# Configuracao de WAN ################## \r\n#\r\n    edit wan\r\n       set mode static\r\n       set vdom \"root\"\r\n       set allowaccess ping https ssh telnet snmp\r\n       set role wan\r\n       set description \"var1\"\r\n       set alias \"WAN\"\r\n    next\r\n#\r\n#\r\n#\r\n#\r\n################# Configuracao de LAN ####################### \r\n#\r\n    edit \"lan1\"\r\n       set vdom \"root\"\r\n       set ip var9 mascaraLAN\r\n       set allowaccess ping fgfm snmp \r\n       set description \"CONEXAO LAN\"\r\n       set alias \"LAN\"\r\n       set role lan\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################## Config - Policies Entrada/Saida ############# \r\n# \r\nconfig firewall policy\r\n     edit 1\r\n       set name \"LAN_WAN\"\r\n       set srcintf \"var5\"\r\n       set dstintf \"var3\"\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n      set action accept\r\n      set schedule \"always\"\r\n       set service \"ALL\"\r\n       set fsso disable\r\n       set nat disable\r\n    next\r\n    edit 2\r\n       set name \"WAN_LAN\"\r\n       set srcintf \"var3\"\r\n       set dstintf \"var5\"\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n       set action accept\r\n       set schedule \"always\"\r\n       set service \"ALL\"\r\n       set fsso disable\r\n      set nat disable\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Rota Estatica ############################## \r\n#\r\nconfig router static\r\n    edit 1\r\n       set gateway var7\r\n       set device var3\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n#\r\n\r\n";

            string fortigateBLDcomVLAN = "# \r\n# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n#\r\n################# Configs - Hostname/Horario ############# \r\n#\r\nconfig system global\r\n    set hostname \"var0\"\r\n   set timezone 18\r\n   set dst disable\r\nend\r\n#\r\n#\r\n################# Deleta DHCP na LAN ################# \r\n#\r\nconfig system dhcp server\r\n   delete 1\r\n   delete 2\r\nend\r\n#\r\n#\r\n################# Limpar Firewall Policy ######################## \r\n#\r\nconfig firewall policy\r\n    purge\r\n    y\r\nend\r\n#\r\n#\r\n################# Remove as Interfaces do Virtual-Switch ############ \r\n# \r\nconfig system virtual-switch\r\n    edit lan\r\n        set physical-switch \"sw0\"\r\n        config port\r\n            delete lan1\r\n            delete lan2\r\n            delete lan3\r\n            #\r\n        end\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n############## Limpeza Interface LAN ##################### \r\n# \r\nconfig system interface\r\n    edit lan\r\n       unset ip\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################# Config - BANER ################ \r\n#\r\nconfig system replacemsg admin pre_admin-disclaimer-text\r\nset buffer \"\r\n||========================================||  \r\n||========== CLARO Brasil S.A. ===========||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\nend\r\nconfig system global\r\n     set pre-login-banner enable\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Usuário/Trusthost ################### \r\n#\r\nconfig system admin\r\n    edit \"EBT\"\r\n       set accprofile \"super_admin\"\r\n       set vdom \"root\"\r\n       set password PRO1AN\r\n       set trusthost1 169.248.255.254 255.255.255.255\r\n       set trusthost2 200.255.156.192 255.255.255.192\r\n       set trusthost3 200.255.122.0 255.255.255.0\r\n       set trusthost5 200.244.28.61 255.255.255.255\r\n       set trusthost6 200.244.27.26 255.255.255.255\r\n       set trusthost7 var7 255.255.255.255\r\n       set trusthost8 var10 255.255.255.255\r\n       set accprofile \"super_admin\"\r\n    next\r\n#\r\n    delete \"admin\"\r\nend\r\n#\r\n#\r\n#\r\n################# Config - NTP Embratel ################ \r\n#\r\nconfig system ntp\r\n    set ntpsync enable\r\n    set type custom\r\n    set syncinterval 1\r\n    config ntpserver\r\n        edit 0\r\n            set server \"200.20.186.75\"\r\n            set server \"200.20.186.94\"\r\n        next\r\n    end\r\n    set server-mode enable\r\n    set interface \"fortilink\"\r\nend\r\n#\r\n#\r\n#\r\n################# Config - SNMP Embratel ################### \r\n#\r\nconfig system snmp community\r\n    edit 0\r\n    set name \"LIDER RO\"\r\n    config hosts\r\n      edit 0\r\n        set ip 200.255.156.194 255.255.255.255\r\n      next\r\n    end\r\n    next\r\n    end\r\n    config system snmp sysinfo\r\n      set status enable\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Interfaces LAN / WAN ############### \r\n#\r\nconfig system interface \r\n#\r\n#\r\n################# Configuracao de WAN ################## \r\n#\r\n    edit wan\r\n       set mode static\r\n       set vdom \"root\"\r\n       set allowaccess ping https ssh telnet snmp\r\n       set role wan\r\n       set description \"var1\"\r\n       set alias \"WAN\"\r\n    next\r\n#\r\n#\r\n#\r\n################# Configuracao VLAN na WAN  #################### \r\n#\r\n    edit \"var3.var4\"\r\n       set vdom \"root\"\r\n       set allowaccess ping https ssh telnet snmp\r\n       set description \"var1\"\r\n       set alias \"WAN\"\r\n       set role wan\r\n       set interface var3\r\n       set vlanid var4\r\n   next\r\n#\r\n#\r\n#\r\n################# Configuracao de LAN ####################### \r\n#\r\n    edit \"lan1\"\r\n       set vdom \"root\"\r\n       set ip var9 255.255.255.252\r\n       set allowaccess ping fgfm snmp \r\n       set description \"CONEXAO LAN\"\r\n       set alias \"LAN\"\r\n       set role lan\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################## Config - Policies Entrada/Saida ############# \r\n# \r\nconfig firewall policy\r\n     edit 1\r\n       set name \"LAN_WAN\"\r\n       set srcintf \"var5\"\r\n       set dstintf \"var3.var4\"\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n      set action accept\r\n      set schedule \"always\"\r\n       set service \"ALL\"\r\n       set fsso disable\r\n       set nat disable\r\n    next\r\n    edit 2\r\n       set name \"WAN_LAN\"\r\n       set srcintf \"var3.var4\"\r\n       set dstintf \"var5\"\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n       set action accept\r\n       set schedule \"always\"\r\n       set service \"ALL\"\r\n       set fsso disable\r\n      set nat disable\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Rota Estatica ############################## \r\n#\r\nconfig router static\r\n    edit 1\r\n       set gateway var7\r\n       set device var3.var4\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n#\r\n\r\n";


            // ------------------------------------------- Config - Huawei - BLD -----------------------------------------------------

            string huaweiBLDcomVLAN = "SYS\r\n#\r\n#\r\nsysname var0\r\n#\r\n#\r\n#\r\n header login information \"\r\n||========================================||  \r\n||===========CLARO Brasil S.A.============||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\n#\r\n#\r\n#\r\n#\r\naaa\r\nundo local-aaa-user password policy access-user\r\nundo local-aaa-user password policy administrator\r\nlocal-user EBT password irreversible-cipher PRO1AN@1\r\nPRO1AN@1\r\nlocal-user EBT service-type telnet terminal ssh\r\nlocal-user EBT privilege level 15 \r\n#\r\nundo local-user admin\r\nquit\r\n#\r\n#\r\n#\r\nundo http secure-server ssl-policy\r\ny\r\n#\r\n#\r\nundo http secure-server enable\r\ny\r\n#\r\n#\r\nundo http server permit interface\r\ny\r\n#\r\n#\r\n#\r\ninterface Vlanif1\r\nundo ip address\r\n#\r\n#\r\n#\r\n#\r\nacl 3000\r\nrule permit ip source var10 0\r\nrule permit ip destination var10 0\r\n#\r\nrule permit ip source var7 0\r\nrule permit ip destination var7 0\r\n#\r\nrule permit ip destination 200.255.156.192 0.0.0.63\r\nrule permit ip source 200.255.156.192 0.0.0.63\r\n#\r\n#\r\n#\r\n#\r\ntraffic classifier var2 operator or\r\nif-match any\r\n# \r\ntraffic behavior var2\r\ncar cir var2\r\n#\r\ntraffic policy var2\r\nclassifier var2 behavior var2 precedence 5\r\n#\r\n#\r\n#\r\ninterface var3\r\n description  var1\r\n bandwidth var2\r\n qos gts cir var2\r\n undo virtualbaudrate\r\n traffic-policy var2 inbound\r\n traffic-policy var2 outbound\r\n#\r\n#\r\n#\r\ninterface var3.var4\r\n description var1\r\n dot1q termination vid var4\r\n bandwidth var2\r\n#\r\n#\r\n#\r\ninterface var5\r\n description  **LAN**\r\n ip address var9 mascaraLAN\r\n#\r\n#\r\n#\r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var7\r\n#\r\n#\r\n#\r\n#\r\nfib regularly-refresh disable\r\ny\r\n#\r\n#\r\ninfo-center loghost source var3.var4\r\ninfo-center loghost var7\r\ninfo-center loghost var9\r\ninfo-center logbuffer size 1024\r\n#\r\n#\r\nundo icmp name timestamp-request receive\r\n#\r\n#\r\n#\r\ntelnet server enable\r\ntelnet server permit interface var3.var4\r\n#\r\n#\r\n#\r\n#\r\nuser-interface con 0\r\n authentication-mode aaa\r\nuser-interface vty 0 4\r\n acl 3000 inbound\r\n authentication-mode aaa\r\n protocol inbound telnet\r\n#\r\n#\r\n#\r\nntp-service refclock-master 12\r\nntp-service unicast-server 200.20.186.94 source-interface var5\r\nntp-service unicast-server 200.20.186.75 source-interface var5 preference\r\n#\r\n#\r\n#\r\nreturn\r\n\r\n";

            string huaweiBLDsemVLAN = "SYS\r\n#\r\n#\r\nsysname var0\r\n#\r\n#\r\n#\r\n header login information \"\r\n||========================================||  \r\n||===========CLARO Brasil S.A.============||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\n#\r\n#\r\n#\r\n#\r\naaa\r\nundo local-aaa-user password policy access-user\r\nundo local-aaa-user password policy administrator\r\nlocal-user EBT password irreversible-cipher PRO1AN@1\r\nPRO1AN@1\r\nlocal-user EBT service-type telnet terminal ssh\r\nlocal-user EBT privilege level 15 \r\n#\r\nundo local-user admin\r\nquit\r\n#\r\n#\r\n#\r\nundo http secure-server ssl-policy\r\ny\r\n#\r\n#\r\nundo http secure-server enable\r\ny\r\n#\r\n#\r\nundo http server permit interface\r\ny\r\n#\r\n#\r\n#\r\ninterface Vlanif1\r\nundo ip address\r\n#\r\n#\r\n#\r\n#\r\nacl 3000\r\nrule permit ip source var10 0\r\nrule permit ip destination var10 0\r\n#\r\nrule permit ip source var7 0\r\nrule permit ip destination var7 0\r\n#\r\nrule permit ip destination 200.255.156.192 0.0.0.63\r\nrule permit ip source 200.255.156.192 0.0.0.63\r\n#\r\n#\r\n#\r\n#\r\ntraffic classifier var2 operator or\r\nif-match any\r\n# \r\ntraffic behavior var2\r\ncar cir var2\r\n#\r\ntraffic policy var2\r\nclassifier var2 behavior var2 precedence 5\r\n#\r\n#\r\n#\r\ninterface var3\r\n description  var1\r\n bandwidth var2\r\n qos gts cir var2\r\n undo virtualbaudrate\r\n traffic-policy var2 inbound\r\n traffic-policy var2 outbound\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\ninterface var5\r\n description  **LAN**\r\n ip address var9 mascaraLAN\r\n#\r\n#\r\n#\r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var7\r\n#\r\n#\r\n#\r\n#\r\nfib regularly-refresh disable\r\ny\r\n#\r\n#\r\ninfo-center loghost source var3\r\ninfo-center loghost var7\r\ninfo-center loghost var9\r\ninfo-center logbuffer size 1024\r\n#\r\n#\r\nundo icmp name timestamp-request receive\r\n#\r\n#\r\n#\r\ntelnet server enable\r\ntelnet server permit interface var3\r\n#\r\n#\r\n#\r\n#\r\nuser-interface con 0\r\n authentication-mode aaa\r\nuser-interface vty 0 4\r\n acl 3000 inbound\r\n authentication-mode aaa\r\n protocol inbound telnet\r\n#\r\n#\r\n#\r\nntp-service refclock-master 12\r\nntp-service unicast-server 200.20.186.94 source-interface var5\r\nntp-service unicast-server 200.20.186.75 source-interface var5 preference\r\n#\r\n#\r\n#\r\nreturn\r\n\r\n";


            // ------------------------------------------- Config - Cisco - MPLS -----------------------------------------------------
            // ------------------------------------------- Config - HPE - MPLS -------------------------------------------------------
            // ------------------------------------------- Config - Fortigate - MPLS -------------------------------------------------

            string fortigateMPLScomVLAN = "#\r\n# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n#\r\n################# Configs - Hostname/Horario ################# \r\n#\r\nconfig system global\r\n   set hostname \"var0\"\r\n   set timezone 18\r\n   set dst disable\r\nend\r\n#\r\n#\r\n################# Deleta DHCP na LAN ################## \r\n#\r\nconfig system dhcp server\r\n   delete 1\r\n   delete 2\r\nend\r\n#\r\n#\r\n################# Limpar Firewall ####################### \r\n#\r\nconfig firewall policy\r\n    purge\r\n    y\r\nend\r\n#\r\n#\r\nconfig firewall address\r\ndelete \"lan\"\r\nend\r\n#\r\n#\r\n########### Remove as Interfaces do Virtual-Switch ########### \r\n#\r\nconfig system virtual-switch\r\n    edit lan\r\n        set physical-switch \"sw0\"\r\n        config port\r\n            delete lan1\r\n            delete lan2\r\n            delete lan3\r\n        end\r\n    next\r\nend\r\n# \r\n# \r\n############## Limpeza Interface LAN ################ \r\n#\r\nconfig system interface\r\n    edit lan\r\n       unset ip\r\n    next\r\nend\r\n#\r\n#\r\n############## Limpeza de Rota Estativa ############ \r\n#\r\nconfig router static\r\npurge\r\ny\r\nend\r\n#\r\n#\r\n################# Config - BANER ################### \r\n#\r\nconfig system replacemsg admin pre_admin-disclaimer-text\r\nset buffer \"\r\n||========================================||  \r\n||========== CLARO Brasil S.A. ===========||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\nend\r\nconfig system global\r\n     set pre-login-banner enable\r\nend\r\n#\r\n#\r\n################# Config - Usuario e Senha ################# \r\n#\r\nconfig system admin\r\nedit \"EBT\"\r\nset accprofile \"super_admin\"\r\nset vdom \"root\"\r\nset password PRO1AN\r\nnext\r\n#\r\n#\r\nedit \"admin\"\r\nset password PRO1AN\r\nnext\r\nend\r\n#\r\n#\r\n################# Config - Interfaces LAN / WAN ################### \r\n#\r\n################# Configuracao de WAN ################## \r\n#\r\nconfig system interface\r\n    edit \"wan\"\r\n       set vdom \"root\"\r\n       set description \"var1\"\r\n       set allowaccess ping https ssh snmp http telnet\r\n       set inbandwidth var2\r\n       set outbandwidth var2\r\n       set alias \"WAN\"\r\n       set type physical\r\n       set role wan\r\n   next\r\n#\r\n################# Configuracao VLAN na WAN  ##################### \r\n#\r\n    edit \"var3.var4\"\r\n       set vdom \"root\"\r\n       set allowaccess ping https ssh telnet snmp\r\n       set description \"var1\"\r\n       set alias \"WAN\"\r\n       set role wan\r\n       set interface var3\r\n       set vlanid var4\r\n   next\r\n#\r\n#\r\n#\r\n#\r\n################# Configuracao de LAN ################## \r\n#\r\n    edit \"lan1\"\r\n        set vdom \"root\"\r\n        set speed auto\r\n        set description \"CONEXAO LAN\"\r\n        set ip var9 255.255.255.252\r\n        set allowaccess ping https ssh snmp http telnet\r\n        set type physical\r\n        set role lan\r\n    next\r\n#\r\n#\r\n################# Loopback Cliente  ##################### \r\n#\r\nedit \"Loopback21\"\r\n        set vdom \"root\"\r\n        set ip var11  mascaraLAN\r\n        set allowaccess ping ssh snmp telnet probe-response\r\n        set icmp-send-redirect disable\r\n        set icmp-accept-redirect disable\r\n        set type loopback\r\n        set description \"Loopback21\"\r\n        next\r\nend\r\n#\r\n#\r\n#################  ROTEAMENTO BGP ################## \r\n#\r\nconfig router bgp\r\n    set as var12\r\n    set log-neighbour-changes enable\r\n    set router-id var7\r\n    config neighbor\r\n    edit \"\"\r\n        set allowas-in-enable enable\r\n        set description \"designacao\"\r\n        set soft-reconfiguration enable\r\n        set remote-as 4230\r\n    next\r\n    end\r\n#\r\n    config redistribute \"connected\"\r\n    set status enable\r\nend\r\nend\r\n#\r\n#\r\n############ POLICY PARA LIBERAR TODO O TRÁFEGO ############# \r\n#\r\nconfig firewall policy\r\n    edit 1\r\n        set name \"ANY\"\r\n        set srcintf \"any\"\r\n        set dstintf \"any\"\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n        set action accept\r\n        set schedule \"always\"\r\n        set service \"ALL\"\r\n        set logtraffic disable\r\n        set diffserv-forward enable\r\n        set diffservcode-forward 000000\r\n    next\r\nend\r\n#\r\n#\r\n\r\n";

            string fortigateMPLsemVLAN = "#\r\n# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n#\r\n################# Configs - Hostname/Horario ################# \r\n#\r\nconfig system global\r\n   set hostname \"var0\"\r\n   set timezone 18\r\n   set dst disable\r\nend\r\n#\r\n#\r\n################# Deleta DHCP na LAN ################## \r\n#\r\nconfig system dhcp server\r\n   delete 1\r\n   delete 2\r\nend\r\n#\r\n#\r\n################# Limpar Firewall ####################### \r\n#\r\nconfig firewall policy\r\n    purge\r\n    y\r\nend\r\n#\r\n#\r\nconfig firewall address\r\ndelete \"lan\"\r\nend\r\n#\r\n#\r\n########### Remove as Interfaces do Virtual-Switch ########### \r\n#\r\nconfig system virtual-switch\r\n    edit lan\r\n        set physical-switch \"sw0\"\r\n        config port\r\n            delete lan1\r\n            delete lan2\r\n            delete lan3\r\n        end\r\n    next\r\nend\r\n# \r\n# \r\n############## Limpeza Interface LAN ################ \r\n#\r\nconfig system interface\r\n    edit lan\r\n       unset ip\r\n    next\r\nend\r\n#\r\n#\r\n############## Limpeza de Rota Estativa ############ \r\n#\r\nconfig router static\r\npurge\r\ny\r\nend\r\n#\r\n#\r\n################# Config - BANER ################### \r\n#\r\nconfig system replacemsg admin pre_admin-disclaimer-text\r\nset buffer \"\r\n||========================================||  \r\n||========== CLARO Brasil S.A. ===========||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\nend\r\nconfig system global\r\n     set pre-login-banner enable\r\nend\r\n#\r\n#\r\n################# Config - Usuario e Senha ################# \r\n#\r\nconfig system admin\r\nedit \"EBT\"\r\nset accprofile \"super_admin\"\r\nset vdom \"root\"\r\nset password PRO1AN\r\nnext\r\n#\r\n#\r\nedit \"admin\"\r\nset password PRO1AN\r\nnext\r\nend\r\n#\r\n#\r\n################# Config - Interfaces LAN / WAN ################### \r\n#\r\n################# Configuracao de WAN ################## \r\n#\r\nconfig system interface\r\n    edit \"wan\"\r\n       set vdom \"root\"\r\n       set description \"var1\"\r\n       set allowaccess ping https ssh snmp http telnet\r\n       set inbandwidth var2\r\n       set outbandwidth var2\r\n       set alias \"WAN\"\r\n       set type physical\r\n       set role wan\r\n   next\r\n#\r\n# \r\n#\r\n################# Configuracao de LAN ################## \r\n#\r\n    edit \"lan1\"\r\n        set vdom \"root\"\r\n        set speed auto\r\n        set description \"CONEXAO LAN\"\r\n        set ip var9 255.255.255.252\r\n        set allowaccess ping https ssh snmp http telnet\r\n        set type physical\r\n        set role lan\r\n    next\r\n#\r\n#\r\n################# Loopback Cliente  ##################### \r\n#\r\nedit \"Loopback21\"\r\n        set vdom \"root\"\r\n        set ip var11  255.255.255.255\r\n        set allowaccess ping ssh snmp telnet probe-response\r\n        set icmp-send-redirect disable\r\n        set icmp-accept-redirect disable\r\n        set type loopback\r\n        set description \"Loopback21\"\r\n        next\r\nend\r\n#\r\n#\r\n#################  ROTEAMENTO BGP ################## \r\n#\r\nconfig router bgp\r\n    set as var12\r\n    set log-neighbour-changes enable\r\n    set router-id var7\r\n    config neighbor\r\n    edit \"\"\r\n        set allowas-in-enable enable\r\n        set description \"\"\r\n        set soft-reconfiguration enable\r\n        set remote-as 4230\r\n    next\r\n    end\r\n#\r\n    config redistribute \"connected\"\r\n    set status enable\r\nend\r\nend\r\n#\r\n#\r\n############ POLICY PARA LIBERAR TODO O TRÁFEGO ############# \r\n#\r\nconfig firewall policy\r\n    edit 1\r\n        set name \"ANY\"\r\n        set srcintf \"any\"\r\n        set dstintf \"any\"\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n        set action accept\r\n        set schedule \"always\"\r\n        set service \"ALL\"\r\n        set logtraffic disable\r\n        set diffserv-forward enable\r\n        set diffservcode-forward 000000\r\n    next\r\nend\r\n#\r\n#\r\n\r\n";


            // ------------------------------------------- Config - Huawei - MPLS ----------------------------------------------------
            // ------------------------------------------- Config - Cisco - VOZ ------------------------------------------------------
            // ------------------------------------------- Config - HPE - VOZ --------------------------------------------------------
            // ------------------------------------------- Config - Aligera - VOZ ----------------------------------------------------
            // ------------------------------------------- Config - Digistar - VOZ ---------------------------------------------------
            // ------------------------------------------- Config - Broadsoft - VOZ --------------------------------------------------


            //--------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------ LOGS --------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Log - Cisco - BLD ------------------------------------------------------

            string ciscoLogsBLDsemLAN = "";

            string ciscoLogsBLDsemLANcomVLANnaWAN = "";

            string ciscoLogsBLDcomLAN = "";

            string ciscoLogsBLDcomLANeVLANnaWAN = "";

            string ciscoLogsBLDcomVLANnaLANeSemVLANnaWAN = "";

            string ciscoLogsBLDcomVLANnasDuas = "";


            // ------------------------------------------- Log - HPE - BLD --------------------------------------------------------

            string hpeLogsBLDsemLAN = "";

            string hpeLogsBLDsemLANcomVLANnaWAN = "";

            string hpeLogsBLDcomLAN = "";

            string hpeLogsBLDcomLANeVLANnaWAN = "";

            string hpeLogsBLDcomVLANnaLANeSemVLANnaWAN = "";

            string hpeLogsBLDcomVLANnasDuas = "";


            // ------------------------------------------- Log - Fortigate - BLD --------------------------------------------------

            string fortigateBLDsemSource = "";

            string fortigateBLDcomSource = "";


            // ------------------------------------------- Log - Huawei - BLD -----------------------------------------------------


            string huaweiLogsBLDsemLAN = "";

            string huaweiLogsBLDsemLANcomVLANnaWAN = "";

            string huaweiLogsBLDcomLAN = "";

            string huaweiLogsBLDcomLANeVLANnaWAN = "";

            string huaweiLogsBLDcomVLANnaLANeSemVLANnaWAN = "";

            string huaweiLogsBLDcomVLANnasDuas = "";


            // ------------------------------------------- Log - Cisco - MPLS ------------------------------------------------------

            string ciscoLogsMPLSsemLAN = "";

            string ciscoLogsMPLSsemLANcomVLANnaWAN = "";

            string ciscoLogsMPLScomLAN = "";

            string ciscoLogsMPLScomLANeVLANnaWAN = "";

            string ciscoLogsMPLScomVLANnaLANeSemVLANnaWAN = "";

            string ciscoLogsMPLScomVLANnasDuas = "";


            // ------------------------------------------- Log - HPE - MPLS -------------------------------------------------------

            string hpeLogsMPLSsemLAN = "";

            string hpeLogsMPLSsemLANcomVLANnaWAN = "";

            string hpeLogsMPLScomLAN = "";

            string hpeLogsMPLScomLANeVLANnaWAN = "";

            string hpeLogsMPLScomVLANnaLANeSemVLANnaWAN = "";

            string hpeLogsMPLScomVLANnasDuas = "";


            // ------------------------------------------- Log - Fortigate - MPLS --------------------------------------------------
            
            string fortigateMPLSsemSource = "";

            string fortigateMPLScomSource = "";


            // ------------------------------------------- Log - Hauwei - MPLS -----------------------------------------------------

            string huaweiLogsMPLSsemLAN = "";

            string huaweiLogsMPLSsemLANcomVLANnaWAN = "";

            string huaweiLogsMPLScomLAN = "";

            string huaweiLogsMPLScomLANeVLANnaWAN = "";

            string huaweiLogsMPLScomVLANnaLANeSemVLANnaWAN = "";

            string huaweiLogsMPLScomVLANnasDuas = "";


            // ------------------------------------------- Log - Cisco - VOZ -------------------------------------------------------

            string ciscoLogsVOZ_R2 = "";

            string ciscoLogsVOZ_PABXIP = "";



            // ------------------------------------------- Log - HPE - VOZ ---------------------------------------------------------

            string hpeLogsVOZ_R2 = "";

            string hpeLogsVOZ_PABXIP = "";


            // ------------------------------------------- Log - Aligera - VOZ -----------------------------------------------------

            string aligeraLogs = "!######### CONFIGURACOES INICIAIS DO CPE ######### \r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!\r\n!#######################################\r\n!# SYSTEM INFO \r\n!#######################################\r\n!\r\nstatus network\r\n!\r\n!\r\nsystem info\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# PING \r\n!#######################################\r\n!\r\ntools ping -c 20 -s 1500 var7\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# STATUS E1 \r\n!#######################################\r\n!\r\nstatus tdm\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# CONFIGURACOES \r\n!#######################################\r\n!\r\nconfig show\r\n!\r\n!\r\n!\r\n";


            // ------------------------------------------- Log - Digistar - VOZ ----------------------------------------------------

            string digistarLogs = "";


            // ------------------------------------------- Log - Broadsoft - VOZ ---------------------------------------------------


            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- WizardGat ------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- WizGat - Cisco - BLD -------------------------------------------------------

            string gatCiscoBLD = "";


            // ------------------------------------------- WizGat - Cisco - MPLS ------------------------------------------------------

            string gatCiscoMPLS = "";


            // ------------------------------------------- WizGat - Cisco - VOZ -------------------------------------------------------

            string gatCiscoVOZ = "";


            // ------------------------------------------- WizGat - Cisco - BLD com BGP -----------------------------------------------

            string gatCiscoBLDcomBGP = "";


            // ------------------------------------------- WizGat - Nokia - BLD -------------------------------------------------------
            
            string gatNOKIABLD = "";


            // ------------------------------------------- WizGat - Nokia - MPLS ------------------------------------------------------
            
            string gatNOKIAMPLS = "";
           
            
            // ------------------------------------------- WizGat - Nokia - VOZ -------------------------------------------------------

            string gatNOKIAVOZ = "";


            // ------------------------------------------- WizGat - Nokia - BLD com BGP -----------------------------------------------

            string gatNOKIABLDcomBGP = "";

            string gatNOKIABLDcomBGProutemap2 = "";


            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- Outros ---------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------





            // -------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------

            List<Script> scriptList = new List<Script>();

            // Config
            Script scriptCiscoBLDsemVlan = new Script("CiscoBLDsemVlan", ciscoBLDsemVlan);
            Script scriptCiscoBLDcomVlan = new Script("CiscoBLDcomVlan", ciscoBLDcomVlan);
            Script scriptHpeBLDcomVlan = new Script("HPEBLDcomVlan", hpeBLDcomVlan);
            Script scriptHpeBLDsemVlan = new Script("HPEBLDsemVlan", hpeBLDsemVlan);
            Script scriptFortigateBLDsemVLAN = new Script("fortigateBLDsemVLAN", fortigateBLDsemVLAN);
            Script scriptFortigateBLDcomVLAN = new Script("fortigateBLDcomVLAN", fortigateBLDcomVLAN);
            Script scriptHuaweiBLDcomVLAN = new Script("huaweiBLDcomVLAN", huaweiBLDcomVLAN);
            Script scriptHuaweiBLDsemVLAN = new Script("huaweiBLDsemVLAN", huaweiBLDsemVLAN);
            Script scriptFortigateMPLScomVLAN = new Script("fortigateMPLScomVLAN", fortigateMPLScomVLAN);
            Script scriptFortigateMPLsemVLAN = new Script("fortigateMPLsemVLAN", fortigateMPLsemVLAN);

            scriptList.Add(scriptCiscoBLDsemVlan);
            scriptList.Add(scriptCiscoBLDcomVlan);
            scriptList.Add(scriptHpeBLDcomVlan);
            scriptList.Add(scriptHpeBLDsemVlan);
            scriptList.Add(scriptFortigateBLDsemVLAN);
            scriptList.Add(scriptFortigateBLDcomVLAN);
            scriptList.Add(scriptHuaweiBLDcomVLAN);
            scriptList.Add(scriptHuaweiBLDsemVLAN);
            scriptList.Add(scriptFortigateMPLScomVLAN);
            scriptList.Add(scriptFortigateMPLsemVLAN);


            // Logs
            Script scriptCiscoLogsBLDsemLAN = new Script("ciscoLogsBLDsemLAN", ciscoLogsBLDsemLAN);
            Script scriptCiscoLogsBLDsemLANcomVLANnaWAN = new Script("ciscoLogsBLDsemLANcomVLANnaWAN", ciscoLogsBLDsemLANcomVLANnaWAN);
            Script scriptCiscoLogsBLDcomLAN = new Script("ciscoLogsBLDcomLAN", ciscoLogsBLDcomLAN);
            Script scriptCiscoLogsBLDcomLANeVLANnaWAN = new Script("ciscoLogsBLDcomLANeVLANnaWAN", ciscoLogsBLDcomLANeVLANnaWAN);
            Script scriptCiscoLogsBLDcomVLANnaLANeSemVLANnaWAN = new Script("ciscoLogsBLDcomVLANnaLANeSemVLANnaWAN", ciscoLogsBLDcomVLANnaLANeSemVLANnaWAN);
            Script scriptCiscoLogsBLDcomVLANnasDuas = new Script("ciscoLogsBLDcomVLANnasDuas", ciscoLogsBLDcomVLANnasDuas);

            scriptList.Add(scriptCiscoLogsBLDsemLAN);
            scriptList.Add(scriptCiscoLogsBLDsemLANcomVLANnaWAN);
            scriptList.Add(scriptCiscoLogsBLDcomLAN);
            scriptList.Add(scriptCiscoLogsBLDcomLANeVLANnaWAN);
            scriptList.Add(scriptCiscoLogsBLDcomVLANnaLANeSemVLANnaWAN);
            scriptList.Add(scriptCiscoLogsBLDcomVLANnasDuas);


            Script scriptHpeLogsBLDsemLAN = new Script("hpeLogsBLDsemLAN", hpeLogsBLDsemLAN);
            Script scriptHpeLogsBLDsemLANcomVLANnaWAN = new Script("hpeLogsBLDsemLANcomVLANnaWAN", hpeLogsBLDsemLANcomVLANnaWAN);
            Script scriptHpeLogsBLDcomLAN = new Script("hpeLogsBLDcomLAN", hpeLogsBLDcomLAN);
            Script scriptHpeLogsBLDcomLANeVLANnaWAN = new Script("hpeLogsBLDcomLANeVLANnaWAN", hpeLogsBLDcomLANeVLANnaWAN);
            Script scriptHpeLogsBLDcomVLANnaLANeSemVLANnaWAN = new Script("hpeLogsBLDcomVLANnaLANeSemVLANnaWAN", hpeLogsBLDcomVLANnaLANeSemVLANnaWAN);
            Script scriptHpeLogsBLDcomVLANnasDuas = new Script("hpeLogsBLDcomVLANnasDuas", hpeLogsBLDcomVLANnasDuas);

            scriptList.Add(scriptHpeLogsBLDsemLAN);
            scriptList.Add(scriptHpeLogsBLDsemLANcomVLANnaWAN);
            scriptList.Add(scriptHpeLogsBLDcomLAN);
            scriptList.Add(scriptHpeLogsBLDcomLANeVLANnaWAN);
            scriptList.Add(scriptHpeLogsBLDcomVLANnaLANeSemVLANnaWAN);
            scriptList.Add(scriptHpeLogsBLDcomVLANnasDuas);


            Script scriptFortigateBLDsemSource = new Script("fortigateBLDsemSource", fortigateBLDsemSource);
            Script scriptFortigateBLDcomSource = new Script("fortigateBLDcomSource", fortigateBLDcomSource);

            scriptList.Add(scriptFortigateBLDsemSource);
            scriptList.Add(scriptFortigateBLDcomSource);


            Script scriptHuaweiLogsBLDsemLAN = new Script("huaweiLogsBLDsemLAN", huaweiLogsBLDsemLAN);
            Script scriptHuaweiLogsBLDsemLANcomVLANnaWAN = new Script("huaweiLogsBLDsemLANcomVLANnaWAN", huaweiLogsBLDsemLANcomVLANnaWAN);
            Script scriptHuaweiLogsBLDcomLAN = new Script("huaweiLogsBLDcomLAN", huaweiLogsBLDcomLAN);
            Script scriptHuaweiLogsBLDcomLANeVLANnaWAN = new Script("huaweiLogsBLDcomLANeVLANnaWAN", huaweiLogsBLDcomLANeVLANnaWAN);
            Script scriptHuaweiLogsBLDcomVLANnaLANeSemVLANnaWAN = new Script("huaweiLogsBLDcomVLANnaLANeSemVLANnaWAN", huaweiLogsBLDcomVLANnaLANeSemVLANnaWAN);
            Script scriptHuaweiLogsBLDcomVLANnasDuas = new Script("huaweiLogsBLDcomVLANnasDuas", huaweiLogsBLDcomVLANnasDuas);

            scriptList.Add(scriptHuaweiLogsBLDsemLAN);
            scriptList.Add(scriptHuaweiLogsBLDsemLANcomVLANnaWAN);
            scriptList.Add(scriptHuaweiLogsBLDcomLAN);
            scriptList.Add(scriptHuaweiLogsBLDcomLANeVLANnaWAN);
            scriptList.Add(scriptHuaweiLogsBLDcomVLANnaLANeSemVLANnaWAN);
            scriptList.Add(scriptHuaweiLogsBLDcomVLANnasDuas);


            Script scriptCiscoLogsMPLSsemLAN = new Script("ciscoLogsMPLSsemLAN", ciscoLogsMPLSsemLAN);
            Script scriptCiscoLogsMPLSsemLANcomVLANnaWAN = new Script("ciscoLogsMPLSsemLANcomVLANnaWAN", ciscoLogsMPLSsemLANcomVLANnaWAN);
            Script scriptCiscoLogsMPLScomLAN = new Script("ciscoLogsMPLScomLAN", ciscoLogsMPLScomLAN);
            Script scriptCiscoLogsMPLScomLANeVLANnaWAN = new Script("ciscoLogsMPLScomLANeVLANnaWAN", ciscoLogsMPLScomLANeVLANnaWAN);
            Script scriptCiscoLogsMPLScomVLANnaLANeSemVLANnaWAN = new Script("ciscoLogsMPLScomVLANnaLANeSemVLANnaWAN", ciscoLogsMPLScomVLANnaLANeSemVLANnaWAN);
            Script scriptCiscoLogsMPLScomVLANnasDuas = new Script("ciscoLogsMPLScomVLANnasDuas", ciscoLogsMPLScomVLANnasDuas);

            scriptList.Add(scriptCiscoLogsMPLSsemLAN);
            scriptList.Add(scriptCiscoLogsMPLSsemLANcomVLANnaWAN);
            scriptList.Add(scriptCiscoLogsMPLScomLAN);
            scriptList.Add(scriptCiscoLogsMPLScomLANeVLANnaWAN);
            scriptList.Add(scriptCiscoLogsMPLScomVLANnaLANeSemVLANnaWAN);
            scriptList.Add(scriptCiscoLogsMPLScomVLANnasDuas);


            Script scriptHpeLogsMPLSsemLAN = new Script("hpeLogsMPLSsemLAN", hpeLogsMPLSsemLAN);
            Script scriptHpeLogsMPLSsemLANcomVLANnaWAN = new Script("hpeLogsMPLSsemLANcomVLANnaWAN", hpeLogsMPLSsemLANcomVLANnaWAN);
            Script scriptHpeLogsMPLScomLAN = new Script("hpeLogsMPLScomLAN", hpeLogsMPLScomLAN);
            Script scriptHpeLogsMPLScomLANeVLANnaWAN = new Script("hpeLogsMPLScomLANeVLANnaWAN", hpeLogsMPLScomLANeVLANnaWAN);
            Script scriptHpeLogsMPLScomVLANnaLANeSemVLANnaWAN = new Script("hpeLogsMPLScomVLANnaLANeSemVLANnaWAN", hpeLogsMPLScomVLANnaLANeSemVLANnaWAN);
            Script scriptHpeLogsMPLScomVLANnasDuas = new Script("hpeLogsMPLScomVLANnasDuas", hpeLogsMPLScomVLANnasDuas);

            scriptList.Add(scriptHpeLogsMPLSsemLAN);
            scriptList.Add(scriptCiscoBLDcomVlan);
            scriptList.Add(scriptHpeLogsMPLSsemLANcomVLANnaWAN);
            scriptList.Add(scriptHpeLogsMPLScomLANeVLANnaWAN);
            scriptList.Add(scriptHpeLogsMPLScomVLANnaLANeSemVLANnaWAN);
            scriptList.Add(scriptHpeLogsMPLScomVLANnasDuas);

            Script scriptFortigateMPLSsemSource = new Script("fortigateMPLSsemSource", fortigateMPLSsemSource);
            Script scriptFortigateMPLScomSource = new Script("fortigateMPLScomSource", fortigateMPLScomSource);

            scriptList.Add(scriptFortigateMPLSsemSource);
            scriptList.Add(scriptFortigateMPLScomSource);

            Script scriptHuaweiLogsMPLSsemLAN = new Script("huaweiLogsMPLSsemLAN", huaweiLogsMPLSsemLAN);
            Script scriptHuaweiLogsMPLSsemLANcomVLANnaWAN = new Script("huaweiLogsMPLSsemLANcomVLANnaWAN", huaweiLogsMPLSsemLANcomVLANnaWAN);
            Script scriptHuaweiLogsMPLScomLAN = new Script("huaweiLogsMPLScomLAN", huaweiLogsMPLScomLAN);
            Script scriptHuaweiLogsMPLScomLANeVLANnaWAN = new Script("huaweiLogsMPLScomLANeVLANnaWAN", huaweiLogsMPLScomLANeVLANnaWAN);
            Script scriptHuaweiLogsMPLScomVLANnaLANeSemVLANnaWAN = new Script("huaweiLogsMPLScomVLANnaLANeSemVLANnaWAN", huaweiLogsMPLScomVLANnaLANeSemVLANnaWAN);
            Script scriptHuaweiLogsMPLScomVLANnasDuas = new Script("huaweiLogsMPLScomVLANnasDuas", huaweiLogsMPLScomVLANnasDuas);

            scriptList.Add(scriptHuaweiLogsMPLSsemLAN);
            scriptList.Add(scriptHuaweiLogsMPLSsemLANcomVLANnaWAN);
            scriptList.Add(scriptHuaweiLogsMPLScomLAN);
            scriptList.Add(scriptHuaweiLogsMPLScomLANeVLANnaWAN);
            scriptList.Add(scriptHuaweiLogsMPLScomVLANnaLANeSemVLANnaWAN);
            scriptList.Add(scriptHuaweiLogsMPLScomVLANnasDuas);

            Script scriptCiscoLogsVOZ_R2 = new Script("ciscoLogsVOZ_R2", ciscoLogsVOZ_R2);
            Script scriptCiscoLogsVOZ_PABXIP = new Script("ciscoLogsVOZ_PABXIP", ciscoLogsVOZ_PABXIP);

            Script scriptHpeLogsVOZ_R2 = new Script("hpeLogsVOZ_R2", hpeLogsVOZ_R2);
            Script scriptHpeLogsVOZ_PABXIP = new Script("hpeLogsVOZ_PABXIP", hpeLogsVOZ_PABXIP);

            Script scriptAligeraLogs = new Script("aligeraLogs", aligeraLogs);
            Script scriptDigistarLogs = new Script("digistarLogs", digistarLogs);

            scriptList.Add(scriptCiscoBLDsemVlan);
            scriptList.Add(scriptCiscoBLDcomVlan);
            scriptList.Add(scriptHpeBLDcomVlan);
            scriptList.Add(scriptHpeBLDsemVlan);
            scriptList.Add(scriptHpeBLDsemVlan);
            scriptList.Add(scriptHpeBLDsemVlan);

            // WizardGat
            Script scriptGatCiscoBLD = new Script("gatCiscoBLD", gatCiscoBLD);
            Script scriptGatCiscoMPLS = new Script("gatCiscoMPLS", gatCiscoMPLS);
            Script scriptGatCiscoVOZ = new Script("gatCiscoVOZ", gatCiscoVOZ);
            Script scriptGatCiscoBLDcomBGP = new Script("gatCiscoBLDcomBGP", gatCiscoBLDcomBGP);
            Script scriptGatNOKIABLD = new Script("gatNOKIABLD", gatNOKIABLD);
            Script scriptGatNOKIAMPLS = new Script("gatNOKIAMPLS", gatNOKIAMPLS);
            Script scriptGatNOKIAVOZ = new Script("gatNOKIAVOZ", gatNOKIAVOZ);
            Script scriptGatNOKIABLDcomBGP = new Script("gatNOKIABLDcomBGP", gatNOKIABLDcomBGP);
            Script scriptGatNOKIABLDcomBGProutemap2 = new Script("gatNOKIABLDcomBGProutemap2", gatNOKIABLDcomBGProutemap2);

            scriptList.Add(scriptGatCiscoBLD);
            scriptList.Add(scriptGatCiscoMPLS);
            scriptList.Add(scriptGatCiscoVOZ);
            scriptList.Add(scriptGatCiscoBLDcomBGP);
            scriptList.Add(scriptGatNOKIABLD);
            scriptList.Add(scriptGatNOKIAMPLS);
            scriptList.Add(scriptGatNOKIAVOZ);
            scriptList.Add(scriptGatNOKIABLDcomBGP);
            scriptList.Add(scriptGatNOKIABLDcomBGProutemap2);


            return scriptList;
        }
    }
}
