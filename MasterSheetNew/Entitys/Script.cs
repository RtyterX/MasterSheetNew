using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Entitys
{
    internal class Script : Object
    {
        int id;
        public string name;
        public string scriptString;
        public string variables;
        public DateTime alterDate;

        public Script(int Id, string Name, string ScriptString, string Variables, DateTime AlterDate)
        {
            id = Id;
            name = Name;
            scriptString = ScriptString;
            variables = Variables;
            alterDate = AlterDate;
        }

        public void AlterScript(Script alteredScript)
        {
            Script script = new Script(99, "ScriptClass", "", "", DateTime.Parse("11/02/2026"));
            List<Script> allScripts = new List<Script>();
            foreach (Script s in allScripts)
            {
                if (s.id == alteredScript.id)
                {
                    script = s;
                }
            }

            script.scriptString = alteredScript.scriptString;
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

            string ciscoLogsBLD = "terminal length 0 \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "undebug all\r\n" +
                    "wr memory\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!############## CONFIGURACOES logType DO CPE ################ \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            CONFIGURACOES            #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show startup-config\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show ip int brief\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            INTERFACES               #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show interface var03\r\n" +
                    "!\r\n" +
                    "!######################## \r\n" +
                    "!\r\n" +
                    "vlanWan" +
                    "!\r\n" +
                    "!######################## \r\n" +
                    "!\r\n" +
                    "intLan" +
                    "!\r\n" +
                    "!######################## \r\n" +
                    "!\r\n" +
                    "vlanLan" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            SYSTEM INFO              #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show version\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show invent\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#              POLICY-MAP             #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show policy-map\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show policy-map interface var03\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "policyLan" +
                    "!#######################################\r\n" +
                    "!#          TABELA DE ROTEAMENTO       #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show ip route summary\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#                PING                 #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "ping var07 repeat 200 size 1500 data 5050 sourceLan \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n";

            string ciscoLogsParte2 = "##### Configuracoes logType no CPE - Parte II ##### \r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ HSRP ################\r\n" +
                "!\r\n" +
                "sh standby bri\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ VRRP ################\r\n" +
                "!\r\n" +
                "sh vrrp bri\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ GLBP ################\r\n" +
                "!\r\n" +
                "sh glbp standby detail active\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ NAT ################\r\n" +
                "!\r\n" +
                "sh ip nat trans\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ OSPF ################\r\n" +
                "!\r\n" +
                "show ip ospf neighbor\r\n" +
                "!\r\n" +
                "show ip ospf interface brief\r\n" +
                "!\r\n" +
                "show ip ospf database\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ RIP ################\r\n" +
                "!\r\n" +
                "show ip rip database\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!################ EIGRP ################\r\n" +
                "!\r\n" +
                "show ip eigrp neighbors\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n";

            string ciscoLogsBLDLimpeza = "!\r\n" +
                "conf t\r\n" +
                "!\r\n" +
                "no ip dhcp excluded-address 10.10.10.1\r\n" +
                "!\r\n" +
                "no ip dhcp pool ccp-pool\r\n" +
                "!\r\n" +
                "no ip domain name yourdomain.com\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki trustpoint TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "yes\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no crypto pki certificate chain TP-self-signed-4256465151\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "default interface Vlan1\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "service password-encryption\r\n" +
                "username EBT privilege 10 password CQMR\r\n" +
                "enable secret PRO1AN\r\n" +
                "logging buffered 4096 debugging\r\n" +
                "!\r\n" +
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
                "!\r\n" +
                "no access-list 23 permit 10.10.10.0 0.0.0.7\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "no banner exec ^C\r\n" +
                "no banner login ^C\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "line con 0\r\n" +
                " no password\r\n" +
                " exec-timeout 15 0\r\n" +
                "login local\r\n" +
                "line aux 0\r\n" +
                " no password\r\n" +
                "login local\r\n" +
                " transport input none\r\n" +
                "line vty 0 4\r\n" +
                " no password\r\n" +
                " exec-timeout 15 0\r\n" +
                " login local\r\n" +
                " transport input telnet ssh\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "banner motd ^C\r\n" +
                "||========================================|| \r\n" +
                "||===========CLARO Brasil S.A.============|| \r\n" +
                "||========================================||  \r\n" +
                "                                             \r\n" +
                "        SOMENTE USUARIOS AUTORIZADOS         \r\n" +
                "           AUTHORIZED USERS ONLY             \r\n" +
                "                                             \r\n" +
                "        OS ACESSOS SERAO MONITORADOS         \r\n" +
                "         ACCESSES WILL BE MONITORED          \r\n" +
                "                                             \r\n" +
                "||========================================||^\r\n" +
                "end\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n";

            string ciscoLogsMPLSLimpeza = "";


            // ------------------------------------------- Log - HPE - BLD --------------------------------------------------------

            string hpeLogsBLD = "screen-length disable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "############## CONFIGURAÇÕES logType DO CPE ################ \r\n" +
                    "#\r\n" +
                    "sys\r\n" +
                    "save f\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#            CONFIGURACOES             #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display saved-configuration\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip interface brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#             INTERFACES               #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display interface var03\r\n" +
                    "#\r\n" +
                    "######################## \r\n" +
                    "#\r\n" +
                    "vlanWan" +
                    "#\r\n" +
                    "#\r\n" +
                    "intLan" +
                    "#\r\n" +
                    "#\r\n" +
                    "vlanLan" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "!#######################################\r\n" +
                    "#            SYSTEM INFO               #\r\n" +
                    "!#######################################\r\n" +
                    "#\r\n" +
                    "display version\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display device manuinfo\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#         TABELA DE ROTEAMENTO         #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display ip routing-table\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table statistics\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#                 PING                 # \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "ping -s 1500 -c 20 sourceLan var07 \r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";
            ;

            string hpeLogsParte2 = "##### Configuracoes logType no CPE - Parte II ##### \r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ VRRP ################\r\n" +
                    "# \r\n" +
                    "display vrrp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ NAT ################\r\n" +
                    "# \r\n" +
                    "display nat session\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ OSPF ################\r\n" +
                    "#\r\n" +
                    "display ospf peer\r\n" +
                    "#\r\n" +
                    "display ospf interface\r\n" +
                    "#\r\n" +
                    "display ospf lsdb\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "################ RIP ################\r\n" +
                    "#\r\n" +
                    "display rip 1 neighbor\r\n" +
                    "#\r\n" +
                    "display rip 1 database\r\n" +
                    "#\r\n" +
                    "display rip 1 route\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";

            string hpeLogsBLDLimpeza = "system-view\r\n" +
                    "#\r\n" +
                    "undo local-user admin class manage\r\n" +
                    "undo snmp-agent\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "domain system\r\n" +
                    "access-limit disable\r\n" +
                    "state active\r\n" +
                    "idle-cut disable\r\n" +
                    "self-service-url disable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "telnet server enable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "local-user EBT\r\n" +
                    "password cipher PRO1AN\r\n" +
                    "authorization-attribute level 3\r\n" +
                    "service-type telnet\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "interface Vlan-interface1\r\n" +
                    " undo ip address\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "undo interface Vlan-interface1 \r\n" +
                    "# \r\n" +
                    "# \r\n" +
                    "undo dhcp server ip-pool lan1\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "user-interface con 0\r\n" +
                    "user-interface tty 13\r\n" +
                    "user-interface vty 0 4\r\n" +
                    "authentication-mode scheme\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "header motd %\r\n" +
                    "||========================================|| \r\n" +
                    "||===========CLARO Brasil S.A.============|| \r\n" +
                    "||========================================|| \r\n" +
                    "                                             \r\n" +
                    "        SOMENTE USUARIOS AUTORIZADOS         \r\n" +
                    "           AUTHORIZED USERS ONLY             \r\n" +
                    "                                             \r\n" +
                    "        OS ACESSOS SERAO MONITORADOS         \r\n" +
                    "         ACCESSES WILL BE MONITORED          \r\n" +
                    "                                             \r\n" +
                    "||========================================|| \r\n" +
                    "%\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "quit\r\n";

            string hpeLogsMPLSLimpeza = "";


            // ------------------------------------------- Log - Fortigate - BLD --------------------------------------------------

            string fortigateBLD = "############ CONFIGURACOES logType ############\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SDWAN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "########### Ver health-check #####################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan health-check status\r\n" +
                    "#\r\n" +
                    "########### Ver regras SDWAN ###################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan service\r\n" +
                    "#\r\n" +
                    "########### Ver membros SDWAN #################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan member\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SNMP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system snmp community\r\n" +
                    "#\r\n" +
                    "show system snmp user\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# DHCP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system dhcp server\r\n" +
                    "#\r\n" +
                    "execute dhcp lease-list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# NTP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system ntp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VRRP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info vrrp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# OSPF \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info ospf interface\r\n" +
                    "#\r\n" +
                    "get router info ospf database brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# HA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system ha status\r\n" +
                    "#\r\n" +
                    "diagnose sys ha status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VPN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "diagnose vpn ike gateway list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "config system console\r\n" +
                    "set output standard\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# CONFIGURAÇÕES DO SYSTEMA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system global\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system admin\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get system status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show vpn certificate local\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# INTERFACES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system interface\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic var03\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic var05\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# FIREWALL POLICY \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "sho firewall policy\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# TABELA DE ROTEAMENTO \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system arp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show router static\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# PING \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "sourceLan" +
                    "#\r\n" +
                    "execute ping-options data 1500\r\n" +
                    "#\r\n" +
                    "execute ping-options repeat 20\r\n" +
                    "#\r\n" +
                    "execute ping var07\r\n" +
                    "#\r\n" +
                    "execute ping-options data 1400\r\n" +
                    "#\r\n" +
                    "execute ping 8.8.8.8\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";

            // ------------------------------------------- Log - Huawei - BLD -----------------------------------------------------


            string huaweiLogsBLD = "########### Configuracoes logType ############\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "screen-length 0 temporary\r\n" +
                    "#\r\n" +
                    "########################################################\r\n" +
                    "#\r\n" +
                    "display vrrp brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display nat session all\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ospf peer\r\n" +
                    "#\r\n" +
                    "display ospf interface\r\n" +
                    "#\r\n" +
                    "display ospf lsdb\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display rip 1 neighbor\r\n" +
                    "#\r\n" +
                    "display rip 1 database\r\n" +
                    "#\r\n" +
                    "display rip 1 route\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "save\r\n" +
                    "y\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# CONFIGURACOES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display saved-configuration\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# INTERFACES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display ip interface brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display interface var03\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "vlanNaWAN" +
                    "#\r\n" +
                    "#\r\n" +
                    "display interface var05\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "vlanLan" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SYSTEM \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display version\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display sn\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# POLICIES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display traffic-policy applied-record\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display traffic policy statistics interface var03 outbound\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display traffic policy user-defined\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# Tabela de Roteamento \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table protocol static\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display ip routing-table statistics\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "ping -s 1500 -c 20 sourceLan var07\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";

            // ------------------------------------------- Log - Cisco - MPLS ------------------------------------------------------

            string ciscoLogsMPLS = "";



            // ------------------------------------------- Log - HPE - MPLS -------------------------------------------------------

            string hpeLogsMPLS = "";



            // ------------------------------------------- Log - Fortigate - MPLS --------------------------------------------------
            
            string fortigateMPLS = "############ CONFIGURACOES logType ############\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SDWAN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "########### Ver health-check #####################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan health-check status\r\n" +
                    "#\r\n" +
                    "########### Ver regras SDWAN ###################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan service\r\n" +
                    "#\r\n" +
                    "########### Ver membros SDWAN #################\r\n" +
                    "#\r\n" +
                    "diagnose sys sdwan member\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# SNMP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system snmp community\r\n" +
                    "#\r\n" +
                    "show system snmp user\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# DHCP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system dhcp server\r\n" +
                    "#\r\n" +
                    "execute dhcp lease-list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# NTP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system ntp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VRRP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info vrrp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# OSPF \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get router info ospf interface\r\n" +
                    "#\r\n" +
                    "get router info ospf database brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# HA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system ha status\r\n" +
                    "#\r\n" +
                    "diagnose sys ha status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# VPN \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "diagnose vpn ike gateway list\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "###########################################################\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "config system console\r\n" +
                    "set output standard\r\n" +
                    "end\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# CONFIGURAÇÕES DO SYSTEMA \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system global\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system admin\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get system status\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show vpn certificate local\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# INTERFACES \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show system interface\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic var03\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get hardware nic var05\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# FIREWALL \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "sho firewall policy\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall traffic-class\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall shaping-profile\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show system dscp-based-priority\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall service custom\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show firewall address\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "diagnose netlink interface list var03\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# TABELA DE ROTEAMENTO \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "get system arp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show router static\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info routing-table all\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "show router route-map\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# BGP \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "show router bgp\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info bgp summary\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info bgp neighbors var07 advertised\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "get router info bgp neighbors var07 routes | grep Total\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "# PING \r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "sourceLan" +
                    "#\r\n" +
                    "execute ping-options data 1500\r\n" +
                    "#\r\n" +
                    "execute ping-options repeat 20\r\n" +
                    "#\r\n" +
                    "execute ping var07\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n";

            // ------------------------------------------- Log - Hauwei - MPLS -----------------------------------------------------

            string huaweiLogsMPLS = "";



            // ------------------------------------------- Log - Cisco - VOZ -------------------------------------------------------

            string ciscoLogsVOZ_R2 = "";

            string ciscoLogsVOZ_PABXIP = "";



            // ------------------------------------------- Log - HPE - VOZ ---------------------------------------------------------

            string hpeLogsVOZ_R2 = "";

            string hpeLogsVOZ_PABXIP = "";


            // ------------------------------------------- Log - Aligera - VOZ -----------------------------------------------------

            string aligeraLogs = "!######### CONFIGURACOES logType DO CPE ######### \r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!\r\n!#######################################\r\n!# SYSTEM INFO \r\n!#######################################\r\n!\r\nstatus network\r\n!\r\n!\r\nsystem info\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# PING \r\n!#######################################\r\n!\r\ntools ping -c 20 -s 1500 var7\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# STATUS E1 \r\n!#######################################\r\n!\r\nstatus tdm\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# CONFIGURACOES \r\n!#######################################\r\n!\r\nconfig show\r\n!\r\n!\r\n!\r\n";


            // ------------------------------------------- Log - Digistar - VOZ ----------------------------------------------------

            string digistarLogs = "";


            // ------------------------------------------- Log - Broadsoft - VOZ ---------------------------------------------------


            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- WizardGat ------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- WizGat - Cisco - BLD -------------------------------------------------------

            string gatCiscoBLD = "!######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                "show interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc var08\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping\r\n" +
                " \r\n" +
                "var08\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";


            // ------------------------------------------- WizGat - Cisco - MPLS ------------------------------------------------------

            string gatCiscoMPLS = "!######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                "show interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# VRF \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config vrf var14\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc var08\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# BGP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config router bgp 4230 vrf var14 neighbor var08\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp xr vrf var14.Text\r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp xr vrf var14 sum | inc var08\r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp xr vrf var14 nei var08 advertised-r | i xes r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgp xr vrf var14 nei var08 ro\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping vrf var14\r\n" +
                "\r\n" +
                "var08\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";


            // ------------------------------------------- WizGat - Cisco - VOZ -------------------------------------------------------

            string gatCiscoVOZ = "!######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# INTERFACE  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                "show interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# VRF  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config vrf REALIP_CLIENTE:5581\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show running-config | inc var08\r\n" +
                " \r\n" +
                " \r\n" +
                "show running-config | inc var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# POLICY-MAP  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "show policy-map interface var03.Text\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "!#######################################\r\n" +
                "!# PING  \r\n" +
                "!#######################################\r\n" +
                " \r\n" +
                "ping vrf REALIP_CLIENTE:5581\r\n" +
                " \r\n" +
                "var08\r\n" +
                "15\r\n" +
                "1500\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";


            // ------------------------------------------- WizGat - Cisco - BLD com BGP -----------------------------------------------

            string gatCiscoBLDcomBGP = "!######## CONFIGURACOES logType ######## \r\n" +
            " \r\n" +
            " \r\n" +
            "!#######################################\r\n" +
            "!# INTERFACE  \r\n" +
            "!#######################################\r\n" +
            " \r\n" +
            "show running-config interface var03\r\n" +
            " \r\n" +
            " \r\n" +
            "show interface var03\r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            "!#######################################\r\n" +
            "!# ROTA ESTATICA  \r\n" +
            "!#######################################\r\n" +
            " \r\n" +
            "show running-config | inc var08\r\n" +
            " \r\n" +
            " \r\n" +
            "show running-config | inc var03\r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            "!#######################################\r\n" +
            "!# POLICY-MAP  \r\n" +
            "!#######################################\r\n" +
            " \r\n" +
            "show policy-map interface var03\r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            "!#######################################\r\n" +
            "!# BGP  \r\n" +
            "!#######################################\r\n" +
            " \r\n" +
            "show running-config router bgp 4230 neighbor var08\r\n" +
            " \r\n" +
            " \r\n" +
            "show bgp sum | inc var08\r\n" +
            " \r\n" +
            " \r\n" +
            "show bgp neighbor var08 routes\r\n" +
            " \r\n" +
            " \r\n" +
            "show bgp neig var08 advertised-routes | inc xes\r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            "!#######################################\r\n" +
            "!# PING  \r\n" +
            "!#######################################\r\n" +
            " \r\n" +
            "ping\r\n" +
            " \r\n" +
            "var03\r\n" +
            "15\r\n" +
            "1500\r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n";


            // ------------------------------------------- WizGat - Nokia - BLD -------------------------------------------------------
            
            string gatNOKIABLD = "######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var07 context all\r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression var03[^0-9] context all\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "show router interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress var13\r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress var13\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var08 context all\r\n" +
                " \r\n" +
                " \r\n" +
                "show router static-route next-hop var08\r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match var08 pre-line 1 post-lines 5\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping var08 size 1500 count 15 interface var03 rapid\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";


            // ------------------------------------------- WizGat - Nokia - MPLS ------------------------------------------------------

            string gatNOKIAMPLS = "######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var07 context all \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression var03[^0-9] context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# VRF  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match expression " + '"' + "route-distinguisher " + "4230:vrfAS" + '"' + " pre-line 8 post-lines 10" + "\r\n" +
                " \r\n" +
                " \r\n" +
                "show router service-name var015 interface var03 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress var13 \r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress var13 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show router service-name var15 static-route next-hop var08 \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match var08 pre-line 1 post-lines 6 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# BGP  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var08 context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "################################# \r\n" +
                "\r\n" +
                "show router service-name var15 bgp summary | match var08 post-lines 3 \r\n" +
                " \r\n" +
                " \r\n" +
                "################################# \r\n" +
                " \r\n" +
                "show router service-name var15 bgp neighbor var08 received-routes \r\n" +
                " \r\n" +
                " \r\n" +
                "################################# \r\n" +
                " \r\n" +
                "show router service-name var15 bgp neighbor var08 advertised-routes | match Routes \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping service-name var15 var08 size 1500 count 15 interface var03 rapid \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";


            // ------------------------------------------- WizGat - Nokia - VOZ -------------------------------------------------------

            string gatNOKIAVOZ = "######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var07 context all \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression var03[^0-9] context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# VRF  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match expression " + '"' + "route-distinguisher " + "4230:5581" + '"' + " pre-line 6 post-lines 6" + " \r\n" +
                " \r\n" +
                " \r\n" +
                "show router service-name 1000 interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress var13\r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress var13\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var08 context all \r\n" +
                " \r\n" +
                " \r\n" +
                "show router service-name 1000 static-route next-hop var08 \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match var08 pre-line 1 post-lines 5 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping service-name 1000 var08 size 1500 count 15 interface var03 rapid\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n";


            // ------------------------------------------- WizGat - Nokia - BLD com BGP -----------------------------------------------

            string gatNOKIABLDcomBGP = "######## CONFIGURACOES logType ######## \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# INTERFACE  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var07 context all \r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match expression var03[^0-9] context all \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "show router interface var03\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# QoS  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show qos sap-ingress var13\r\n" +
                " \r\n" +
                " \r\n" +
                "show qos sap-egress var13\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# ROTA ESTATICA  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "show router static-route next-hop var08\r\n" +
                " \r\n" +
                " \r\n" +
                "admin display-config | match var08 pre-line 1 post-lines 56 \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# BGP   \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "admin display-config | match var08 context all \r\n" +
                " \r\n" +
                " \r\n" +
                "######## BGP - ROUTE MAPS ######## \r\n" +
                " \r\n" +
                "show router policy VarRouteI1\r\n" +
                " \r\n" +
                " \r\n" +
                "show router policy VarRouteI2\r\n" +
                " \r\n" +
                " \r\n" +
                "show router policy VarRouteE1\r\n" +
                " \r\n" +
                " \r\n" +
                "policyExport2" +
                " \r\n" +
                " \r\n" +
                "######## BGP - NEIGHBORS ######## \r\n" +
                " \r\n" +
                "show router bgp neighbor var08 advertised-routes | match Routes\r\n" +
                " \r\n" +
                " \r\n" +
                "show router bgp summary | match var08 post-lines 3\r\n" +
                " \r\n" +
                " \r\n" +
                "show router bgp neighbor var08 received-routes\r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n" +
                "########################################\r\n" +
                "# PING  \r\n" +
                "########################################\r\n" +
                " \r\n" +
                "ping var08 size 1500 count 15 interface var03 rapid \r\n" +
                " \r\n" +
                " \r\n" +
                " \r\n"; ;


            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- Outros ---------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            string snmpv2Cisco = "snmp-server community VarCom VarTipo";

            string snmpv2CiscoHost = "snmp - server community VarCom VarTipo \r\nsnmp-server host VarHost VarCom\r\n";

            string snmpv2HPE = "snmp-agent\r\n" +
                "snmp-agent local-engineid\r\n" +
                "snmp-agent community VarTipo VarCom\r\n" +
                "snmp-agent sys-info version all\r\n";

            string snmpv2HPEcomHost = "snmp-agent\r\n" +
                "snmp-agent local-engineid\r\n" +
                "snmp-agent community VarTipo VarCom\r\n" +
                "snmp-agent sys-info version all\r\n" +
                "snmp-agent target-host trap address udp-domain VarHost params securityname VarCom\r\n";

            string snmpv2Huawei = "snmp-agent target-host trap-paramsname SNMPV1 v1 securityname VarCom\r\n" +
                "snmp-agent target-host trap-paramsname SNMPV2 v2c securityname VarCom\r\n";

            string snmpv2HuaweicomHost = "snmp-agent target-host trap-paramsname SNMPV1 v1 securityname VarCom\r\n" +
                "snmp-agent target-host trap-paramsname SNMPV2 v2c securityname VarCom\r\n" +
                "snmp-agent target-host trap-hostname host1 address VarHost trap-paramsnam SNMPV1\r\n" +
                "snmp-agent target-host trap-hostname host2 address VarHost trap-paramsnam SNMPV2\r\n";

            string snmpv2Fortgate = "config system snmp community\r\n" +
                "    edit 0\r\n" +
                "        set name " + '"' + "EBT" + '"' + "\r\n" +
                "        config hosts\r\n" +
                "        edit 0\r\n" +
                "          set ip VarHost 255.255.255.255\r\n" +
                "          next\r\n" +
                "        end\r\n" +
                "    next\r\n" +
                "    end\r\n" +
                "config system snmp sysinfo\r\n" +
                "    set status enable\r\n" +
                "end\r\n" +
                "config system admin\r\n" +
                "    edit " + '"' + "EBT" + '"' + "\r\n" +
                "       set trusthost4 VarHost 255.255.255.2555\r\n" +
                "    next\r\n" +
                "end\r\n";


            // -------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------

            List<Script> scriptList = new List<Script>();

            // Config
            Script scriptCiscoBLDsemVlan = new Script(0, "CiscoBLDsemVlan", ciscoBLDsemVlan, "var0,var1,var2,var3,var4,var5,var7,var9,var10", DateTime.Parse("11/02/2026"));
            Script scriptCiscoBLDcomVlan = new Script(1, "CiscoBLDcomVlan", ciscoBLDcomVlan, "var0,var1,var2,var3,var4,var5,var7,var9,var10", DateTime.Parse("11/02/2026"));
            Script scriptHpeBLDcomVlan = new Script(2, "HPEBLDcomVlan", hpeBLDcomVlan, "00,01,02,03,04,05,07,09,10", DateTime.Parse("11/02/2026"));
            Script scriptHpeBLDsemVlan = new Script(3, "HPEBLDsemVlan", hpeBLDsemVlan, "00,01,02,03,04,05,07,09,10", DateTime.Parse("11/02/2026"));
            Script scriptFortigateBLDsemVLAN = new Script(4, "fortigateBLDsemVLAN", fortigateBLDsemVLAN, "00,01,02,03,04,05,07,09,10", DateTime.Parse("11/02/2026"));
            Script scriptFortigateBLDcomVLAN = new Script(5,"fortigateBLDcomVLAN", fortigateBLDcomVLAN, "00,01,02,03,04,05,07,09,10", DateTime.Parse("11/02/2026"));
            Script scriptHuaweiBLDcomVLAN = new Script(6, "huaweiBLDcomVLAN", huaweiBLDcomVLAN, "00,01,02,03,04,05,07,09,10", DateTime.Parse("11/02/2026"));
            Script scriptHuaweiBLDsemVLAN = new Script(7, "huaweiBLDsemVLAN", huaweiBLDsemVLAN, "00,01,02,03,04,05,07,09,10", DateTime.Parse("11/02/2026"));
            Script scriptFortigateMPLScomVLAN = new Script(8, "fortigateMPLScomVLAN", fortigateMPLScomVLAN, "00,01,02,03,04,05,07,09,11,12", DateTime.Parse("11/02/2026"));
            Script scriptFortigateMPLsemVLAN = new Script(9, "fortigateMPLsemVLAN", fortigateMPLsemVLAN, "00,01,02,03,04,05,07,09,11,12", DateTime.Parse("11/02/2026"));

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
            Script scriptCiscoLogsBLD = new Script(10, "ciscoLogsBLD", ciscoLogsBLD, "03,04,05,06,07", DateTime.Parse("11/02/2026"));
            Script scriptHpeLogsBLD = new Script(11, "hpeLogsBLD", hpeLogsBLD, "03,04,05,06,07,09", DateTime.Parse("11/02/2026"));
            Script scriptFortigateBLD = new Script(12, "fortigateBLD", fortigateBLD, "03,05,07,09", DateTime.Parse("11/02/2026"));
            Script scriptHuaweiLogsBLD = new Script(13, "huaweiLogsBLD", huaweiLogsBLD, "03,04,05,06,07,09", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoLogsBLD);
            scriptList.Add(scriptHpeLogsBLD);
            scriptList.Add(scriptFortigateBLD);
            scriptList.Add(scriptHuaweiLogsBLD);

            Script scriptCiscoLogsMPLS = new Script(14, "ciscoLogsMPLS", ciscoLogsMPLS, "03,04,05,06,07", DateTime.Parse("11/02/2026"));
            Script scriptHpeLogsMPLS = new Script(15, "hpeLogsMPLS", hpeLogsMPLS, "03,04,05,06,07,09", DateTime.Parse("11/02/2026"));
            Script scriptFortigateMPLS = new Script(16, "fortigateMPLS", fortigateMPLS, "03,05,07,09", DateTime.Parse("11/02/2026"));
            Script scriptHuaweiLogsMPLS = new Script(17, "huaweiLogsMPLS", huaweiLogsMPLS, "03,04,05,06,07,09", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoLogsMPLS);
            scriptList.Add(scriptHpeLogsMPLS);
            scriptList.Add(scriptFortigateMPLS);
            scriptList.Add(scriptHuaweiLogsMPLS);

            Script scriptCiscoLogsVOZ_R2 = new Script(18, "ciscoLogsVOZ_R2", ciscoLogsVOZ_R2, "03,04,05,07", DateTime.Parse("11/02/2026"));
            Script scriptCiscoLogsVOZ_PABXIP = new Script(19, "ciscoLogsVOZ_PABXIP", ciscoLogsVOZ_PABXIP, "03,04,05,07", DateTime.Parse("11/02/2026"));
            Script scriptHpeLogsVOZ_R2 = new Script(20, "hpeLogsVOZ_R2", hpeLogsVOZ_R2, "03,04,05,07,09", DateTime.Parse("11/02/2026"));
            Script scriptHpeLogsVOZ_PABXIP = new Script(21, "hpeLogsVOZ_PABXIP", hpeLogsVOZ_PABXIP, "03,04,05,07,09", DateTime.Parse("11/02/2026"));
            Script scriptAligeraLogs = new Script(22, "aligeraLogs", aligeraLogs, "07", DateTime.Parse("11/02/2026"));
            Script scriptDigistarLogs = new Script(23, "digistarLogs", digistarLogs, "07, 03, 04", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoLogsVOZ_R2);
            scriptList.Add(scriptCiscoLogsVOZ_PABXIP);
            scriptList.Add(scriptHpeLogsVOZ_R2);
            scriptList.Add(scriptHpeLogsVOZ_PABXIP);
            scriptList.Add(scriptAligeraLogs);
            scriptList.Add(scriptDigistarLogs);

            // WizardGat
            Script scriptGatCiscoBLD = new Script(24, "gatCiscoBLD", gatCiscoBLD, "03,08", DateTime.Parse("11/02/2026"));
            Script scriptGatCiscoMPLS = new Script(25, "gatCiscoMPLS", gatCiscoMPLS, "03,08,14,15", DateTime.Parse("11/02/2026"));
            Script scriptGatCiscoVOZ = new Script(26, "gatCiscoVOZ", gatCiscoVOZ, "03,08", DateTime.Parse("11/02/2026"));
            Script scriptGatCiscoBLDcomBGP = new Script(27, "gatCiscoBLDcomBGP", gatCiscoBLDcomBGP, "03,08", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIABLD = new Script(28, "gatNOKIABLD", gatNOKIABLD, "03,08,14,15", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIAMPLS = new Script(29, "gatNOKIAMPLS", gatNOKIAMPLS, "03,07,08,13,14,15", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIAVOZ = new Script(30, "gatNOKIAVOZ", gatNOKIAVOZ, "03,07,08,13", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIABLDcomBGP = new Script(31, "gatNOKIABLDcomBGP", gatNOKIABLDcomBGP, "03,07,08,13", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptGatCiscoBLD);
            scriptList.Add(scriptGatCiscoMPLS);
            scriptList.Add(scriptGatCiscoVOZ);
            scriptList.Add(scriptGatCiscoBLDcomBGP);
            scriptList.Add(scriptGatNOKIABLD);
            scriptList.Add(scriptGatNOKIAMPLS);
            scriptList.Add(scriptGatNOKIAVOZ);
            scriptList.Add(scriptGatNOKIABLDcomBGP);

            // Outros
            Script scriptSnmpv2Cisco = new Script(32, "snmpv2Cisco", snmpv2Cisco, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2CiscoHost = new Script(33, "snmpv2CiscoHost", snmpv2CiscoHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2HPE = new Script(34, "snmpv2HPE", snmpv2HPE, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2HPEcomHost = new Script(35, "snmpv2HPEcomHost", snmpv2HPEcomHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2Huawei = new Script(36, "snmpv2Huawei", snmpv2Huawei, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2HuaweicomHost = new Script(37, "snmpv2HuaweicomHost", snmpv2HuaweicomHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2Fortgate = new Script(38, "snmpv2Fortgate", snmpv2Fortgate, "Outros_VarText00,Outros_VarText01, Outros_VarText03", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptSnmpv2Cisco);
            scriptList.Add(scriptSnmpv2CiscoHost);
            scriptList.Add(scriptSnmpv2HPE);
            scriptList.Add(scriptSnmpv2HPEcomHost);
            scriptList.Add(scriptSnmpv2Huawei);
            scriptList.Add(scriptSnmpv2HuaweicomHost);
            scriptList.Add(scriptSnmpv2Fortgate);

            // Extras
            Script scriptCiscoLogsParte2 = new Script(39, "ciscoLogsParte2", ciscoLogsParte2, "", DateTime.Parse("11/02/2026"));
            Script scriptCiscoLogsBLDLimpeza = new Script(40, "ciscoLogsBLDLimpeza", ciscoLogsBLDLimpeza, "", DateTime.Parse("11/02/2026"));
            Script scriptHPELogsParte2 = new Script(41, "hpeLogsParte2", hpeLogsParte2, "", DateTime.Parse("11/02/2026"));
            Script scriptHPELogsBLDLimpeza = new Script(42, "hpeLogsBLDLimpeza", hpeLogsBLDLimpeza, "", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoLogsParte2);
            scriptList.Add(scriptCiscoLogsBLDLimpeza);
            scriptList.Add(scriptHPELogsParte2);
            scriptList.Add(scriptHPELogsBLDLimpeza);


            // -----------------------------------------------------
            return scriptList;
        }
    }
}
