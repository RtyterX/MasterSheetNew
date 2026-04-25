using System;
using System.Collections.Generic;

namespace MasterSheetNew.Entitys
{
    public class Script : Object
    {
        public int id;
        public string name;
        public bool clientOrNot;
        public string scriptString;
        public string variables;
        public string variableNames;
        public DateTime alterDate;

        // Used to Display the correct name on DataSource
        public override string ToString()
        {
            return name;
        }

        public Script(int Id, string Name, bool ClientOrNot, string ScriptString, string Variables, string VariableNames, DateTime AlterDate)
        {
            id = Id;
            name = Name;
            clientOrNot = ClientOrNot;
            scriptString = ScriptString;
            variables = Variables;
            variableNames = VariableNames;
            alterDate = AlterDate;
        }

        public void AlterScript(Script alteredScript)
        {
            Script script = new Script(99, "ScriptClass", false, "", "", "", DateTime.Parse("11/02/2026"));
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
            // ------------------------------------------- Config - Cisco - BLD ------------------------------------------------------
            #region
            string ciscoBLD = "conf t \r\n" +
                "!\r\n" +
                "!\r\n" +
                "hostname var00 \r\n" +
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
                "no ip ssh version 1\r\n" +
                "ip ssh version 2\r\n" +
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
                "permit ip host var07 any\r\n" +
                "permit ip any host var07\r\n" +
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
                " shape average var02000\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# CONFIGURACOES DE INTERFACES \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "interface var03\r\n" +
                " description var01\r\n" +
                " bandwidth var02\r\n" +
                " service-policy output SHAPE_OUT\r\n" +
                " no shut\r\n" +
                "quit\r\n" +
                "!\r\n" +
                "!\r\n" +
                "withVlan" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "interface var05\r\n" +
                " description ** LAN **\r\n" +
                " ip address var09 mascaraLAN\r\n" +
                " no ip redirects\r\n" +
                " no ip unreachables\r\n" +
                " no ip proxy-arp\r\n" +
                " duplex auto\r\n" +
                " speed auto\r\n" +
                " no shutdown\r\n" +
                " no cdp enable\r\n" +
                "quit\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!\r\n" +
                "!###################################################### \r\n" +
                "!# ROTA ESTATICA \r\n" +
                "!###################################################### \r\n" +
                "!\r\n" +
                "ip route 0.0.0.0 0.0.0.0 var07\r\n" +
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
                "ntp server 200.20.186.75 prefer source var03vlanNTP\r\n" +
                "ntp server 200.20.186.94 source var03vlanNTP\r\n" +
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
                "||========== CLARO Brasil S.A. ==============||  \r\n" +
                "||========================================||  \r\n" +
                "                                              \r\n" +
                "        SOMENTE USUARIOS AUTORIZADOS          \r\n" +
                "           AUTHORIZED USERS ONLY              \r\n" +
                "                                              \r\n" +
                "        OS ACESSOS SERAO MONITORADOS          \r\n" +
                "         ACCESSES WILL BE MONITORED           \r\n" +
                "                                              \r\n" +
                "||========================================|| \r\n" +
                "^\r\n" +
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
            #endregion
            // ------------------------------------------- Config - HPE - BLD --------------------------------------------------------
            #region
            string hpeBLD = "#\r\n" +
                "system-view\r\n" +
                "#\r\n" +
                "#\r\n" +
                "sysname var00\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DE USUARIO # \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "local-user EBT class manage\r\n" +
                "password simple PRO1AN\r\n" +
                "PRO1AN\r\n" +
                "service-type telnet\r\n" +
                "service-type telnet terminal\r\n" +
                " service-type ftp\r\n" +
                " authorization-attribute user-role network-admin\r\n" +
                " authorization-attribute user-role network-operator\r\n" +
                "telnet server enable\r\n" +
                "password-recovery enable\r\n" +
                "info-center logbuffer size 1024\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# LIMPEZA # \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "undo local-user admin class manage\r\n" +
                "#\r\n" +
                "#\r\n" +
                "undo dns proxy enable\r\n" +
                "#\r\n" +
                "#\r\n" +
                "interface GigabitEthernet0/0\r\n" +
                "undo ip address dhcp-alloc\r\n" +
                "#\r\n" +
                "#\r\n" +
                "undo dhcp server ip-pool lan1\r\n" +
                "undo dhcp enable\r\n" +
                "undo dhcp server always-broadcast\r\n" +
                "#\r\n" +
                "#\r\n" +
                "undo interface Vlan-interface1\r\n" +
                "#\r\n" +
                "#\r\n" +
                "undo ip http enable\r\n" +
                "#\r\n" +
                "#\r\n" +
                "undo nqa entry imclinktopologypleaseignore ping\r\n" +
                "undo nqa schedule imclinktopologypleaseignore ping\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DE INTERFACES # \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "interface var03" +
                "\r\n" +
                "port link-mode route\r\n" +
                "undo virtualbaudrate\r\n" +
                "description var01\r\n" +
                "bandwidth var02\r\n" +
                "qos gts any cir var02\r\n" +
                "quit\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "withVlan" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "interface var05\r\n" +
                "port link-mode route\r\n" +
                "description ** LAN **\r\n" +
                "ip address var09 mascaraLAN\r\n" +
                "quit\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# ROTA ESTATICA # \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "ip route-static 0.0.0.0 0.0.0.0 var07\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# BLOQUEIO - ACCESS LIST # \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "acl advanced 3000\r\n" +
                "#\r\n" +
                "rule 5 permit ip source var10 0" +
                "\r\n" +
                "rule 10 permit ip destination var10 0\r\n" +
                "rule 10 comment IP LOOPBACK PE\r\n" +
                "#\r\n" +
                "rule 15 permit ip source var07 0\r\n" +
                "rule 20 permit ip destination var07 0\r\n" +
                "rule 20 comment IP PE - CCTO" +
                "#\r\n" +
                "#\r\n" +
                "rule 25 permit ip destination 200.255.156.192 0.0.0.63\r\n" +
                "rule 30 permit ip source 200.255.156.192 0.0.0.63\r\n" +
                "rule 30 comment IP GERENCIA GCPE\r\n" +
                "#\r\n" +
                "#\r\n" +
                "telnet server acl 3000\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DE SNMP \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "snmp-agent community read LIDER\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# CONFIGURACOES DO RELOGIO INTERNO \r\n" +
                "###################################################### \r\n" +
                "# \r\n" +
                "clock timezone BR minus 03:00:00\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# NTP PARA OS SERVIDORES NTP DO OBSERVATORIO NACIONAL \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "ntp-service enable\r\n" +
                "ntp-service unicast-server 200.20.186.75 priority source var05\r\n" +
                "ntp-service unicast-server 200.20.186.94 source var05\r\n" +
                "ntp-service refclock-master 12\r\n" +
                "#\r\n" +
                "clock protocol ntp\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# CONFIG PARA HABILITAR O SSH \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "local-user EBT\r\n" +
                " service-type telnet terminal ssh\r\n" +
                "#\r\n" +
                "#\r\n" +
                "public-key local create rsa\r\n" +
                "y\r\n" +
                "1024\r\n" +
                "#\r\n" +
                "#\r\n" +
                "ssh server enable\r\n" +
                "ssh server acl 3000\r\n" +
                "#\r\n" +
                "#\r\n" +
                "#\r\n" +
                "###################################################### \r\n" +
                "# BANNER - USER INTERFACE \r\n" +
                "###################################################### \r\n" +
                "#\r\n" +
                "user-interface con 0\r\n" +
                " authentication-mode scheme\r\n" +
                "user-interface tty 13\r\n" +
                "user-interface aux 0\r\n" +
                " authentication-mode scheme\r\n" +
                "user-interface vty 0 4\r\n" +
                " authentication-mode scheme\r\n" +
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
                "return\r\n" +
                "#\r\n";
            #endregion
            // ------------------------------------------- Config - HPE Old - BLD ----------------------------------------------------
            #region
            string hpeOldBLD = "system-view\r\n#\r\nlocal-user EBT\r\npassword simple PRO1AN\r\nPRO1AN\r\nauthorization-attribute level 3\r\nservice-type telnet terminal\r\nservice-type ftp\r\nundo local-user admin\r\ntelnet server enable\r\n#\r\nundo dhcp enable\r\nundo dhcp server always-broadcast\r\n#\r\nundo dns proxy enable\r\n#\r\ninterface GigabitEthernet0/0\r\nundo ip address dhcp-alloc\r\n#\r\nundo dhcp server ip-pool lan1\r\n#\r\nundo interface Vlan-interface1\r\n#\r\nundo local-user admin class manage\r\n#\r\nundo ip http enable\r\n#\r\nSysname Var00\r\n#\r\ninterface Var05\r\nport link-mode route\r\ndescription ** LAN **\r\nip address Var09 mascaraLAN\r\n#\r\n#\r\n#\r\ninterface Var03\r\ndescription  Var01\r\nport link-mode route\r\nbandwidth Var02\r\nundo virtualbaudrate\r\nqos gts any cir  Var02\r\n#\r\n#\r\nwithVlan\r\n#\r\nip route-static 0.0.0.0 0.0.0.0 Var07\r\n#\r\n#\r\n#\r\n#\r\nuser-interface con 0\r\n authentication-mode scheme\r\nuser-interface tty 13\r\nuser-interface aux 0\r\n authentication-mode scheme\r\nuser-interface vty 0 4\r\n authentication-mode scheme\r\n#\r\n header motd %\r\n||========================================||\r\n||========== CLARO Brasil S.A. ===========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n%\r\n#\r\n############################################################\r\n# RESPONDER TRACEROUTE\r\n############################################################\r\n#\r\nip unreachables enable\r\nip ttl-expires enable\r\n#\r\n############################################################\r\n# CONFIGURACOES DE RESTRICAO DO TELNET\r\n############################################################\r\n#\r\nacl number 3000\r\ndescription BLOQUEIO_TELNET\r\nrule 5 remark IP LOOPBACK PE\r\nrule 10 permit ip source Var10 0\r\nrule 15 permit ip destination Var10 0\r\n#\r\nrule 20 remark IP PE - CCTO\r\nrule 25 permit ip source Var07 0\r\nrule 30 permit ip destination Var07 0\r\n#\r\nrule 35 remark IP GERENCIA GCPE\r\nrule 40 permit ip destination 200.255.156.192 0.0.0.63\r\nrule 45 permit ip source 200.255.156.192 0.0.0.63\r\n#\r\nuser-interface vty 0 4\r\nacl 3000 inbound\r\nacl 3000 outbound\r\nauthentication-mode scheme\r\n#\r\n############################################################\r\n#  CONFIGURAÇÃO DE SNMP\r\n############################################################\r\n#\r\nsnmp-agent\r\nsnmp-agent community read LIDER\r\n#\r\n############################################################\r\n# CONFIGURACOES DO RELOGIO INTERNO DO CPE\r\n############################################################\r\n#\r\nclock timezone BR minus 03:00:00\r\n#\r\n############################################################\r\n# NTP PARA OS SERVIDORES NTP DO OBSERVATORIO NACIONAL\r\n############################################################\r\n#\r\nntp-service unicast-server 200.20.186.75 priority source-interface Var05\r\nntp-service unicast-server 200.20.186.94 source-interface Var05\r\n#\r\n############################################################\r\n# CONFIG PARA HABILITAR O SSH\r\n############################################################\r\n#\r\nlocal-user EBT\r\n service-type telnet terminal ssh\r\n#\r\npublic-key local create rsa\r\n1024\r\n#\r\nssh server enable\r\n#\r\n############################################################\r\n#\r\ninterface Vlan-interface1\r\nundo ip address\r\n#\r\nundo nqa entry imclinktopologypleaseignore ping\r\nundo nqa schedule imclinktopologypleaseignore ping\r\nundo interface Vlan-interface1\r\n# \r\nreturn\r\n#";
            #endregion
            // ------------------------------------------- Config - Fortigate - BLD --------------------------------------------------
            #region
            string fortigateBLD = "# \r\n# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n#\r\n################# Configs - Hostname/Horario ############# \r\n#\r\nconfig system global\r\n    set hostname \"var00\"\r\n   set timezone 18\r\n   set dst disable\r\nend\r\n#\r\n#\r\n################# Deleta DHCP na LAN ################# \r\n#\r\nconfig system dhcp server\r\n   delete 1\r\n   delete 2\r\nend\r\n#\r\n#\r\n################# Limpar Firewall Policy ######################## \r\n#\r\nconfig firewall policy\r\n    purge\r\n    y\r\nend\r\n#\r\n#\r\n################# Remove as Interfaces do Virtual-Switch ############ \r\n# \r\nconfig system virtual-switch\r\n    edit lan\r\n        set physical-switch \"sw0\"\r\n        config port\r\n            delete lan1\r\n            delete lan2\r\n            delete lan3\r\n            #\r\n        end\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n############## Limpeza Interface LAN ##################### \r\n# \r\nconfig system interface\r\n    edit lan\r\n       unset ip\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################# Config - BANER ################ \r\n#\r\nconfig system replacemsg admin pre_admin-disclaimer-text\r\nset buffer \"\r\n||========================================||  \r\n||========== CLARO Brasil S.A. ===========||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\nend\r\nconfig system global\r\n     set pre-login-banner enable\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Usuário/Trusthost ################### \r\n#\r\nconfig system admin\r\n    edit \"EBT\"\r\n       set vdom \"root\"\r\n       set password PRO1AN\r\n       set trusthost1 169.248.255.254 255.255.255.255\r\n       set trusthost2 200.255.156.192 255.255.255.192\r\n       set trusthost3 200.255.122.0 255.255.255.0\r\n       set trusthost5 200.244.28.61 255.255.255.255\r\n       set trusthost6 200.244.27.26 255.255.255.255\r\n       set trusthost7 var07 255.255.255.255\r\n       set trusthost8 var10 255.255.255.255\r\n       set accprofile \"super_admin\"\r\n    next\r\n#\r\n    delete \"admin\"\r\nend\r\n#\r\n#\r\n#\r\n################# Config - NTP Embratel ################ \r\n#\r\nconfig system ntp\r\n    set ntpsync enable\r\n    set type custom\r\n    set syncinterval 1\r\n    config ntpserver\r\n        edit 0\r\n            set server \"200.20.186.75\"\r\n            set server \"200.20.186.94\"\r\n        next\r\n    end\r\n    set server-mode enable\r\n    set interface \"fortilink\"\r\nend\r\n#\r\n#\r\n#\r\n################# Config - SNMP Embratel ################### \r\n#\r\nconfig system snmp community\r\n    edit 0\r\n    set name \"LIDER RO\"\r\n    config hosts\r\n      edit 0\r\n        set ip 200.255.156.194 255.255.255.255\r\n      next\r\n    end\r\n    next\r\n    end\r\n    config system snmp sysinfo\r\n      set status enable\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Interfaces LAN / WAN ############### \r\n#\r\n#\r\n################# Configuracao de WAN ################## \r\n#\r\nconfig system interface \r\n    edit \"var03\"\r\n       set mode static\r\n       set vdom \"root\"\r\n       set allowaccess ping https ssh telnet snmp\r\n       set role wan\r\n       set description \"var01\"\r\n       set alias \"WAN\"\r\n    next\r\ny\r\n#\r\n#\r\n#\r\nwithVlan\r\n#\r\n#\r\n#\r\n################# Configuracao de LAN ####################### \r\n#\r\n    edit \"var05\"\r\n       set vdom \"root\"\r\n       set ip var09 mascaraLAN\r\n       set allowaccess ping fgfm snmp \r\n       set description \"CONEXAO LAN\"\r\n       set alias \"LAN\"\r\n       set role lan\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################## Config - Policies Entrada/Saida ############# \r\n# \r\nconfig firewall policy\r\n     edit 1\r\n       set name \"LAN_WAN\"\r\n       set srcintf \"var05\"\r\n       set dstintf \"var03sourceLan\"\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n      set action accept\r\n      set schedule \"always\"\r\n       set service \"ALL\"\r\n       set fsso disable\r\n       set nat disable\r\n    next\r\n    edit 2\r\n       set name \"WAN_LAN\"\r\n       set srcintf \"var03sourceLan\"\r\n       set dstintf \"var05\"\r\n       set srcaddr \"all\"\r\n       set dstaddr \"all\"\r\n       set action accept\r\n       set schedule \"always\"\r\n       set service \"ALL\"\r\n       set fsso disable\r\n      set nat disable\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n################# Config - Rota Estatica ############################## \r\n#\r\nconfig router static\r\n    edit 1\r\n       set gateway var07\r\n       set device var03sourceLan\r\n    next\r\nend\r\n#\r\n#\r\n#\r\n#\r\n\r\n";
            #endregion
            // ------------------------------------------- Config - Huawei - BLD -----------------------------------------------------
            #region
            string huaweiBLD = "system-view\r\n#\r\n#\r\nsysname var00\r\n#\r\n#\r\n#\r\nheader login information \"\r\n||========================================||\r\n||=========== CLARO Brasil S.A. ==========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n\"\r\n#\r\n#\r\n#\r\n#\r\naaa\r\nundo local-aaa-user password policy access-user\r\nundo local-aaa-user password policy administrator\r\nlocal-user EBT password irreversible-cipher PRO1AN@1\r\nPRO1AN@1\r\nlocal-user EBT service-type telnet terminal ssh\r\nlocal-user EBT privilege level 15\r\n#\r\nundo local-user admin\r\nquit\r\n#\r\n#\r\n#\r\nundo http secure-server ssl-policy\r\ny\r\n#\r\n#\r\nundo http secure-server enable\r\ny\r\n#\r\n#\r\nundo http server permit interface\r\n#\r\n#\r\n#\r\ninterface Vlanif1\r\n undo ip address\r\n#\r\n#\r\n#\r\ndns resolve\r\ndns proxy enable\r\ny\r\n#\r\n#\r\n#\r\ndhcp enable \r\n#\r\n#\r\n#\r\nacl 3000\r\nrule permit ip source var10 0\r\nrule permit ip destination var10 0\r\n#\r\nrule permit ip source var07 0\r\nrule permit ip destination var07 0\r\n#\r\nrule permit ip destination 200.255.156.192 0.0.0.63\r\nrule permit ip source 200.255.156.192 0.0.0.63\r\n#\r\n#\r\n#\r\n#\r\ntraffic classifier var02 operator or\r\nif-match any\r\n#\r\ntraffic behavior var02\r\ncar cir  var02\r\n#\r\ntraffic policy var02\r\nclassifier var02 behavior var02 precedence 5\r\n#\r\n#\r\n#\r\n# \r\ninterface var03\r\ndescription var01 \r\nbandwidth var02\r\nqos gts cir var02\r\ntraffic-policy var02 inbound\r\ntraffic-policy var02 outbound\r\n#\r\n#\r\nwithVlan\r\n#\r\ninterface var05\r\ndescription  **LAN**\r\nip address var09 mascaraLAN\r\n#\r\n#\r\n#\r\n#\r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var07\r\n# \r\n#\r\n#\r\n#\r\n#\r\nfib regularly-refresh disable\r\ny\r\n#\r\n#\r\ninfo-center loghost source var03infosource\r\ninfo-center loghost var07\r\ninfo-center loghost var09\r\ninfo-center logbuffer size 1024\r\n#\r\n#\r\nundo icmp name timestamp-request receive\r\n#\r\n#\r\n#\r\ntelnet server enable\r\ntelnet server permit interface var03telsource\r\n#\r\n#\r\n#\r\n#\r\nuser-interface con 0 \r\n authentication-mode aaa \r\nuser-interface vty 0 4 \r\n acl 3000 inbound \r\n authentication-mode aaa \r\n user privilege level 15\r\n protocol inbound telnet \r\n# \r\n#\r\n#\r\n#\r\n#\r\n ntp-service refclock-master 12 \r\n ntp-service unicast-server 200.20.186.94 source-interface var05\r\n ntp-service unicast-server 200.20.186.75 source-interface var05 preference\r\n# \r\n#\r\n#\r\n#\r\nreturn\r\n";
            #endregion
            // ------------------------------------------- Config - Cisco - MPLS -----------------------------------------------------
            #region
            string ciscoMPLS = "conf t\r\n!\r\nhostname var00\r\n!\r\n!\r\n!###################################################### \r\n!# CONFIGURACAO DE USUARIO # \r\n!###################################################### \r\n!\r\nservice password-encryption \r\nusername EBT privilege 10 password CQMR \r\nenable secret PRO1AN \r\nlogging buffered 4096 debugging \r\nservice tcp-keepalives-in \r\nservice tcp-keepalives-out \r\nno enable password \r\nservice timestamps debug datetime msec localtime show-timezone \r\nservice timestamps log datetime msec localtime show-timezone \r\n!\r\n!\r\nno username cisco\r\nno username admin\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# LIMPEZA \r\n!###################################################### \r\n!\r\nno ip domain name yourdomain.com\r\nno ip domain lookup \r\n!\r\n!\r\nconfig-register 0x2102\r\nno username cisco\r\nno username admin\r\n!\r\n!\r\nno ip dhcp excluded-address 10.10.10.1\r\nno ip dhcp pool ccp-pool\r\n!\r\n!\r\nno access-list 23 permit 10.10.10.0 0.0.0.7\r\n!\r\n!\r\nip forward-protocol nd \r\n!\r\nno ip http server\r\nno ip http secure-server\r\nno ip http access-class 23\r\nno ip http authentication local\r\nno ip http timeout-policy idle 60 life 86400 requests 10000\r\nno logging trap notifications\r\n!\r\n!\r\n!\r\nno crypto pki trustpoint TP-self-signed-4256465151\r\nyes\r\n!\r\n!\r\nno crypto pki certificate chain TP-self-signed-4256465151\r\n!\r\n!\r\n!r\n!\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# CONFIGURACOES DE INTERFACES \r\n!###################################################### \r\n!\r\ninterface var03\r\n description var01\r\n bandwidth var02\r\n no shut\r\nquit\r\n!\r\n!\r\nwithVlan\r\n!\r\ninterface var05\r\n description ** LAN **\r\nip address var09 mascaraLAN\r\n no shutdown\r\n no ip redirects\r\n no ip unreachables\r\n no ip proxy-arp\r\n duplex auto\r\n speed auto\r\n no cdp enable\r\n no auto-summary \r\nquit\r\n!\r\n!\r\n!\r\n!\r\n!######################################################\r\n!### REMOCAO DE ROTA ESTATICA ### \r\n!###################################################### \r\n!\r\nno ip route 0.0.0.0 0.0.0.0 var07\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# BGP\r\n!######################################################\r\n!\r\nrouter bgp var12\r\nno synchronization \r\nbgp log-neighbor-changes \r\nredistribute connected \r\nneighbor var07 remote-as 4230\r\nneighbor var07 send-community\r\nneighbor var07 allowas-in\r\nneighbor var07 description designacao\r\nneighbor var07 soft-reconfiguration inbound\r\nno auto-summary \r\n! \r\n! \r\n! \r\n!###################################################### \r\n!# BANNER - USER INTERFACE \r\n!###################################################### \r\n!\r\nbanner motd ^\r\n||========================================||\r\n||========== CLARO Brasil S.A. ===========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||^\r\n!\r\n!\r\n!\r\nno banner exec ^C \r\nno banner login ^C \r\n!\r\n!\r\n!\r\nline con 0\r\n no password\r\n login local\r\nline aux 0\r\n no password\r\n login local\r\nline vty 0 4\r\n no privilege level 15\r\n no password\r\n no access-class 23 in\r\n login local\r\n transport input all\r\n!\r\n!\r\n!\r\n!\r\nend";
            #endregion
            // ------------------------------------------- Config - HPE - MPLS -------------------------------------------------------
            #region
            string hpeMPLS = "system-view\r\n#\r\n#\r\nsysname var00\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACAO DE USUARIO # \r\n###################################################### \r\n#\r\nlocal-user EBT class manage \r\npassword simple PRO1AN \r\nPRO1AN\r\n service-type telnet \r\n service-type telnet terminal \r\n service-type ftp \r\n authorization-attribute user-role network-admin \r\n authorization-attribute user-role network-operator \r\n#\r\n#\r\ntelnet server enable \r\npassword-recovery enable \r\ninfo-center logbuffer size 1024 \r\n#\r\n#\r\n#\r\n###################################################### \r\n# LIMPEZA # \r\n######################################################\r\n#\r\nundo ip http enable\r\nundo local-user admin class manage\r\nundo interface Vlan-interface1\r\nundo dhcp enable\r\nundo dhcp server always-broadcast\r\nundo dhcp server ip-pool lan1\r\nundo dns proxy enable\r\n#\r\n#\r\ninterface GigabitEthernet0/0\r\nundo ip address dhcp-alloc\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACAO DE INTERFACES # \r\n######################################################\r\n#\r\ninterface var03\r\ndescription  var01\r\nport link-mode route\r\nundo virtualbaudrate\r\nbandwidth var02\r\nquit\r\n#\r\n#\r\nwithVlan\r\n#\r\ninterface var05\r\nport link-mode route\r\ndescription ** LAN **\r\nip address var09 mascaraLAN\r\nquit\r\n#\r\n#\r\n#\r\n###################################################### \r\n# REMOCAO DE ROTA ESTATICA\r\n###################################################### \r\n#\r\nundo ip route-static 0.0.0.0 0.0.0.0 var07\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BGP \r\n###################################################### \r\n#\r\nbgp var12\r\npeer var07 as-number 4230\r\npeer var07 description designacao\r\n#\r\naddress-family ipv4 unicast\r\nimport-route direct\r\npeer var07 enable\r\npeer var07 allow-as-loop 10\r\npeer var07 advertise-community\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BANNER - USER INTERFACE \r\n###################################################### \r\n#\r\n header motd %\r\n||=============CLARO Brasil S.A.============||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n%\r\n#\r\n#\r\n#\r\nreturn\r\n#";
            #endregion
            // ------------------------------------------- Config - HPE Old - MPLS ---------------------------------------------------
            #region
            string hpeOldMPLS = "system-view\r\n#\r\nlocal-user EBT\r\nundo ip route-static 0.0.0.0 0.0.0.0 Var07\r\npassword simple PRO1AN\r\nauthorization-attribute level 3\r\nservice-type telnet terminal\r\nservice-type ftp\r\nundo local-user admin\r\ntelnet server enable\r\n#\r\nundo ip http enable\r\n#\r\nSysname Var00\r\n#\r\n#\r\n#\r\n#\r\n header motd %\r\n||========================================||\r\n||========== CLARO Brasil S.A. ===========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n%\r\n#\r\ninterface Vlan-interface1\r\nundo ip address\r\nundo snmp-agent\r\nundo nqa entry imclinktopologypleaseignore ping\r\nundo nqa schedule imclinktopologypleaseignore ping\r\nundo interface Vlan-interface1\r\n#\r\ninterface Var05\r\nport link-mode route\r\ndescription ** LAN **\r\nip addres Var09 mascaraLAN\r\n#\r\ninterface Var03\r\ndescription  Var01\r\nport link-mode route\r\nundo virtualbaudrate\r\nbandwidth Var02\r\n#\r\n#\r\n#\r\nwithVlan\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\nundo ip route-static 0.0.0.0 0.0.0.0 Var07\r\n#\r\n#\r\n#\r\n#\r\n#\r\nbgp Var12\r\npeer Var07 as-number 4230\r\npeer Var07 description Var01\r\n#\r\n import-route direct\r\n import-route static\r\n undo synchronization\r\npeer Var07 as-number 4230\r\npeer Var07 allow-as-loop 10\r\npeer Var07 description Var01\r\npeer Var07 enable\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\nuser-interface con 0\r\n authentication-mode scheme\r\nuser-interface tty 13\r\nuser-interface aux 0\r\n authentication-mode scheme\r\nuser-interface vty 0 4\r\n authentication-mode scheme\r\n#\r\n# \r\nreturn";
            #endregion
            // ------------------------------------------- Config - Huawei - MPLS ----------------------------------------------------
            #region
            string huaweiMPLS = "system-view\r\n#\r\n#\r\nsysname var00\r\n#\r\n#\r\n#\r\nheader login information \"\r\n||========================================||\r\n||=========== CLARO Brasil S.A. ==========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n\"\r\n#\r\n#\r\n#\r\n#\r\naaa\r\nundo local-aaa-user password policy access-user\r\nundo local-aaa-user password policy administrator\r\nlocal-user EBT password irreversible-cipher PRO1AN@1\r\nPRO1AN@1\r\nlocal-user EBT service-type telnet terminal ssh\r\nlocal-user EBT privilege level 15\r\n#\r\nundo local-user admin\r\nquit\r\n#\r\n#\r\n#\r\nundo http secure-server ssl-policy\r\ny\r\n#\r\n#\r\nundo http secure-server enable\r\ny\r\n#\r\n#\r\nundo http server permit interface\r\n#\r\n#\r\n#\r\ninterface Vlanif1\r\n undo ip address\r\n#\r\n#\r\n#\r\ndns resolve\r\ndns proxy enable\r\ny\r\n#\r\n#\r\n#\r\ndhcp enable \r\n#\r\n#\r\n#\r\ndrop illegal-mac alarm\r\n#\r\nauthentication-profile name default_authen_profile\r\nauthentication-profile name dot1x_authen_profile\r\nauthentication-profile name dot1xmac_authen_profile\r\nauthentication-profile name mac_authen_profile\r\nauthentication-profile name multi_authen_profile\r\nauthentication-profile name portal_authen_profile\r\nquit\r\n#\r\n#\r\n#\r\nradius-server template default\r\nquit\r\n#\r\n#\r\npki realm default\r\n certificate-check none\r\nquit\r\n#\r\n#\r\n#\r\n#\r\n#\r\nssl policy default_policy type server\r\n pki-realm default\r\n version tls1.2\r\n ciphersuite rsa_aes_128_sha256 rsa_aes_256_sha256 ecdhe_rsa_aes128_gcm_sha256 ecdhe_rsa_aes256_gcm_sha384\r\ny\r\nquit\r\n#\r\n#\r\n#\r\nike proposal default\r\nencryption-algorithm aes-256 aes-192 aes-128\r\ny\r\n dh group14\r\n authentication-algorithm sha2-512 sha2-384 sha2-256\r\n authentication-method pre-share\r\n integrity-algorithm hmac-sha2-256\r\n prf hmac-sha2-256\r\nquit\r\n#\r\n#\r\n#\r\n#\r\nfree-rule-template name default_free_rule\r\n#\r\n#\r\n#\r\nportal-access-profile name portal_access_profile\r\n#\r\n#\r\n#\r\nweb\r\n set fast-configuration state disable\r\n#\r\n#\r\n#\r\ncellular profile default\r\n modem auto-recovery dial action modem-reboot fail-times 128\r\n modem auto-recovery icmp-unreachable action modem-reboot\r\n modem auto-recovery services-unavailable action modem-reboot test-times 0 interval 3600\r\n#\r\n#\r\n#\r\n# \r\n# \r\ninterface var03\r\ndescription var01 \r\nbandwidth var02\r\n# \r\n# \r\n#\r\n# \r\nwithVlan\r\n#\r\ninterface var05\r\ndescription  **LAN**\r\nip address var09 mascaraLAN\r\n#\r\n#\r\n#\r\n#\r\nundo ip route-static 0.0.0.0 0.0.0.0 var07\r\n# \r\n#\r\n#\r\n#\r\nbgp var12\r\n router-id var08\r\n peer var07 as-number 4230\r\n peer var07 description designacao\r\n #\r\n ipv4-family unicast\r\n  undo synchronization\r\n  import-route direct\r\n  import-route static\r\n  peer var07 enable\r\n  peer var07 allow-as-loop 10\r\n#\r\n#\r\n#\r\n#\r\nfib regularly-refresh disable\r\ny\r\n#\r\n#\r\ninfo-center loghost source var03infosource\r\ninfo-center loghost var07\r\ninfo-center loghost var09\r\ninfo-center logbuffer size 1024\r\n#\r\n#\r\nundo icmp name timestamp-request receive\r\n#\r\n#\r\n#\r\ntelnet server enable\r\ntelnet server permit interface var03telsource\r\n#\r\n#\r\n#\r\nuser-interface con 0 \r\n authentication-mode aaa \r\nuser-interface vty 0 4 \r\n acl 3000 inbound \r\n authentication-mode aaa \r\n user privilege level 15\r\n protocol inbound telnet \r\n#\r\n#\r\n#\r\n#\r\n#\r\nreturn";
            #endregion
            // ------------------------------------------- Config - Fortigate - MPLS -------------------------------------------------
            #region
            string fortigateMPLS = "#\r\n# Jogar as configurações em blocos do 'edit' até o 'end' (Salva). \r\n#\r\n################# Configs - Hostname/Horario ################# \r\n#\r\nconfig system global\r\n   set hostname \"var00\"\r\n   set timezone 18\r\n   set dst disable\r\nend\r\n#\r\n#\r\n################# Deleta DHCP na LAN ################## \r\n#\r\nconfig system dhcp server\r\n   delete 1\r\n   delete 2\r\nend\r\n#\r\n#\r\n################# Limpar Firewall ####################### \r\n#\r\nconfig firewall policy\r\n    purge\r\n    y\r\nend\r\n#\r\n#\r\nconfig firewall address\r\ndelete \"lan\"\r\nend\r\n#\r\n#\r\n########### Remove as Interfaces do Virtual-Switch ########### \r\n#\r\nconfig system virtual-switch\r\n    edit lan\r\n        set physical-switch \"sw0\"\r\n        config port\r\n            delete lan1\r\n            delete lan2\r\n            delete lan3\r\n        end\r\n    next\r\nend\r\n# \r\n# \r\n############## Limpeza Interface LAN ################ \r\n#\r\nconfig system interface\r\n    edit lan\r\n       unset ip\r\n    next\r\nend\r\n#\r\n#\r\n############## Limpeza de Rota Estativa ############ \r\n#\r\nconfig router static\r\npurge\r\ny\r\nend\r\n#\r\n#\r\n################# Config - BANER ################### \r\n#\r\nconfig system replacemsg admin pre_admin-disclaimer-text\r\nset buffer \"\r\n||========================================||  \r\n||========== CLARO Brasil S.A. ===========||  \r\n||========================================||  \r\n                                              \r\n        SOMENTE USUARIOS AUTORIZADOS          \r\n           AUTHORIZED USERS ONLY              \r\n                                              \r\n        OS ACESSOS SERAO MONITORADOS          \r\n         ACCESSES WILL BE MONITORED           \r\n                                              \r\n||========================================||  \r\n\"\r\nend\r\nconfig system global\r\n     set pre-login-banner enable\r\nend\r\n#\r\n#\r\n################# Config - Usuario e Senha ################# \r\n#\r\nconfig system admin\r\nedit \"EBT\"\r\nset accprofile \"super_admin\"\r\nset vdom \"root\"\r\nset password PRO1AN\r\nnext\r\n#\r\n#\r\nedit \"admin\"\r\nset password PRO1AN\r\nnext\r\nend\r\n#\r\n#\r\n################# Config - Interfaces LAN / WAN ################### \r\n#\r\n#\r\n################# Configuracao de WAN ################## \r\n#\r\nconfig system interface\r\n    edit \"var03\"\r\n       set vdom \"root\"\r\n       set description \"var01\"\r\n       set allowaccess ping https ssh snmp http telnet\r\n       set inbandwidth var02\r\n       set outbandwidth var02\r\n       set alias \"WAN\"\r\n       set type physical\r\n       set role wan\r\n   next\r\ny\r\n#\r\n#\r\nwithVlan\r\n#\r\n#\r\n#\r\n\r\n#\r\n#\r\n################# Configuracao de LAN ################## \r\n#\r\n    edit \"var05\"\r\n        set vdom \"root\"\r\n        set speed auto\r\n        set description \"CONEXAO LAN\"\r\n        set ip var09 mascaraLAN\r\n        set allowaccess ping https ssh snmp http telnet\r\n        set type physical\r\n        set role lan\r\n    next\r\n#\r\n#\r\n#\r\n################# Loopback Cliente  ##################### \r\n#\r\nedit \"Loopback21\"\r\n        set vdom \"root\"\r\n        set ip var11  255.255.255.255\r\n        set allowaccess ping ssh snmp telnet probe-response\r\n        set icmp-send-redirect disable\r\n        set icmp-accept-redirect disable\r\n        set type loopback\r\n        set description \"Loopback21\"\r\n        next\r\nend\r\n#\r\n#\r\n#\r\n\r\n#################  ROTEAMENTO BGP ################## \r\n#\r\nconfig router bgp\r\n    set as var12\r\n    set log-neighbour-changes enable\r\n    set router-id var08\r\n    config neighbor\r\n    edit \"var07\"\r\n        set allowas-in-enable enable\r\n        set description \"designacao\"\r\n        set soft-reconfiguration enable\r\n        set remote-as 4230\r\n    next\r\n    end\r\n#\r\n    config redistribute \"connected\"\r\n    set status enable\r\nend\r\nend\r\n#\r\n#\r\n############ POLICY PARA LIBERAR TODO O TRÁFEGO ############# \r\n#\r\nconfig firewall policy\r\n    edit 1\r\n        set name \"ANY\"\r\n        set srcintf \"any\"\r\n        set dstintf \"any\"\r\n        set srcaddr \"all\"\r\n        set dstaddr \"all\"\r\n        set action accept\r\n        set schedule \"always\"\r\n        set service \"ALL\"\r\n        set logtraffic disable\r\n        set diffserv-forward enable\r\n        set diffservcode-forward 000000\r\n    next\r\nend\r\n#\r\n#\r\n\r\n";
            #endregion
            // ------------------------------------------- Config - Cisco - VOZ ------------------------------------------------------
            #region
            string ciscoR2 = "conf t\r\n!\r\nhostname var00\r\n!\r\n!\r\n############### Usuarios ################\r\n!\r\nservice password-encryption\r\n!\r\nusername EBT privilege 10 password 0 CQMR\r\nenable secret PRO1AN\r\n!\r\n!\r\n!\r\n############### Limpeza ################\r\n!\r\nno access-list 23 permit 10.10.10.0 0.0.0.7\r\n!\r\n!\r\n!\r\n############### Card Type ################\r\n!\r\ncard type e1 0 1\r\n!\r\nnetwork-clock-participate wic 1\r\n!\r\nvoice service voip \r\n    ip address trusted authenticate   \r\n    ip address trusted list                              \r\n     ipv4 0.0.0.0 0.0.0.0\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n sip\r\n!\r\n!\r\n!\r\nvoice class codec 1\r\n codec preference 1 g729r8\r\n codec preference 2 g729br8\r\n codec preference 3 g711alaw\r\n!\r\n!\r\n!\r\n############### Regras de Saida ################\r\n!\r\nvoice translation-rule 10\r\nrule 1 /^\\(Var19\\)/ /\\1/\r\nrule 2 /^\\(SaidaRegra1\\)/ /SaidaRegra2\\1/\r\nrule 3 /^.*/ /Var17/\r\n!\r\n!\r\nvoice translation-profile EBT_BSOD\r\n translate calling 10\r\n!\r\n!\r\nvoice-card 0\r\n dsp services dspfarm\r\n!\r\n!\r\n!\r\n############### Policy Map ################\r\n!\r\nclass-map match-any Voz_RealIp\r\n match  dscp cs3  ef \r\nclass-map match-any NetworkControl_RealIp\r\n match  dscp cs2  cs6  cs7 \r\n!\r\n!\r\npolicy-map Voz_Ger\r\n class Voz_RealIp\r\npolice rate bandaQoS000\r\n     conform-action transmit \r\n     exceed-action drop \r\n class NetworkControl_RealIp\r\n    bandwidth 63\r\n    queue-limit 32\r\n class class-default\r\n     random-detect\r\npolicy-map Saida_Voz\r\n class class-default\r\n shape average var02000\r\n  service-policy Voz_Ger\r\n!\r\n!\r\n!\r\n############### Interface ################\r\n!\r\nInterface var03\r\ndescription var01\r\nband var02\r\nservice-policy output Saida_Voz\r\nno shut\r\n!\r\n!\r\nwithVlan\r\n!\r\n!\r\nip route 0.0.0.0 0.0.0.0 var07\r\n!\r\n!\r\n!\r\n!\r\n!############### Dial-peers ################\r\n!\r\n!\r\ndial-peer voice 100 voip\r\ndescription LOCAL\r\ndestination-pattern [2-8].......\r\nrtp payload-type cisco-codec-fax-ack 111\r\nrtp payload-type cisco-codec-fax-ind 110\r\nrtp payload-type nse 102\r\nrtp payload-type nte 97\r\nmodem passthrough nse codec g711alaw\r\nvoice-class codec 1\r\nsession protocol sipv2\r\nsession target sip-server\r\nincoming called-number .T\r\ndtmf-relay rtp-nte\r\nplayout-delay mode fixed no-timestamps\r\nfax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\nno vad\r\n!\r\ndial-peer voice 101 voip\r\ndescription LONGA_DISTANCIA\r\ndestination-pattern 0[1-9].[1-9][1-9][2-8].......$\r\nrtp payload-type cisco-codec-fax-ack 111\r\nrtp payload-type cisco-codec-fax-ind 110\r\nrtp payload-type nse 102\r\nrtp payload-type nte 97\r\nmodem passthrough nse codec g711alaw\r\nvoice-class codec 1\r\nsession protocol sipv2\r\nsession target sip-server\r\ndtmf-relay rtp-nte\r\nplayout-delay mode fixed no-timestamps\r\nfax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\nno vad\r\n!\r\ndial-peer voice 102 voip\r\ndescription A_COBRAR_LOCAL\r\ndestination-pattern 9090[2-8].......$\r\nrtp payload-type cisco-codec-fax-ack 111\r\nrtp payload-type cisco-codec-fax-ind 110\r\nrtp payload-type nse 102\r\nrtp payload-type nte 97\r\nmodem passthrough nse codec g711alaw\r\nvoice-class codec 1\r\nsession protocol sipv2\r\nsession target sip-server\r\ndtmf-relay rtp-nte\r\nplayout-delay mode fixed no-timestamps\r\nfax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\nno vad\r\n!\r\ndial-peer voice 103 voip\r\ndescription A_COBRAR_LONGA_DISTANCIA\r\ndestination-pattern 90[1-9].[1-9][1-9][2-8].......$\r\nrtp payload-type cisco-codec-fax-ack 111\r\nrtp payload-type cisco-codec-fax-ind 110\r\nrtp payload-type nse 102\r\nrtp payload-type nte 97\r\nmodem passthrough nse codec g711alaw\r\nvoice-class codec 1\r\nsession protocol sipv2\r\nsession target sip-server\r\ndtmf-relay rtp-nte\r\nplayout-delay mode fixed no-timestamps\r\nfax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\nno vad\r\n!\r\ndial-peer voice 104 voip\r\n description ZERO_800\r\ndestination-pattern 0800......T\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 105 voip\r\n description ZERO_300\r\n destination-pattern 0300......T\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 106 voip\r\n description INTERNACIONAL\r\n destination-pattern 00.T\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 107 voip\r\n description Servicos_Publicos\r\n destination-pattern 1..T\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol pass-through g711alaw\r\n no vad\r\n!\r\n!\r\ndial-peer voice 109 voip\r\n description IG_Provedores\r\n destination-pattern 1[5-9]......\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 101\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\n!\r\ndial-peer voice 110 voip\r\n description ZERO_500\r\n destination-pattern 0500......T\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 114 voip\r\n description LONGA_DISTANCIA_9_digito_SP\r\n destination-pattern 0[1-9].[1-9][1-9]9........$\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 115 voip\r\n description LONGA_DISTANCIA_SERVICOS\r\n destination-pattern 0[1-9].[1-9][1-9]1..T\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 116 voip\r\n description A_COBRAR_LOCAL_9_DIGITOS_SP\r\n destination-pattern 90909........$\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 117 voip\r\n description A_COBRAR_LONGA_DISTANCIA\r\n destination-pattern 90[^0][^0][1-9][1-9]9........$\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n no vad\r\n!\r\n!\r\ndial-peer voice 118 voip\r\n description SERVICOS_PUBLICOS\r\n destination-pattern 19.\r\n rtp payload-type cisco-codec-fax-ack 111\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n voice-class codec 1\r\n session protocol sipv2\r\n session target sip-server\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol pass-through g711alaw\r\n no vad\r\n!\r\ndial-peer voice 119 voip\r\ndescription LOCAL CELULAR 9 DIGITO\r\ndestination-pattern 9........\r\nrtp payload-type cisco-codec-fax-ack 111\r\nrtp payload-type cisco-codec-fax-ind 110\r\nrtp payload-type nse 102\r\nrtp payload-type nte 97\r\nmodem passthrough nse codec g711alaw\r\nvoice-class codec 1\r\nsession protocol sipv2\r\nsession target sip-server\r\ndtmf-relay rtp-nte\r\nplayout-delay mode fixed no-timestamps\r\nfax protocol t38 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\nno vad\r\n!\r\n!\r\n!\r\n!\r\n!############### Controller ################\r\n!\r\nsinalizacao\r\n!\r\n!\r\n!\r\n!\r\n!############### Voice Port ################\r\n!\r\nvoice-port portVoice \r\n translation-profile incoming EBT_BSOD\r\n no vad\r\n no comfort-noise\r\n cptone BR\r\n timeouts interdigit 5\r\n!\r\n!\r\n!\r\n!############### Regras de Entrada ################\r\n!\r\ndial-peer voice 10 pots\r\n description INBOUND  Rede Publica para tronco Vipline\r\n  trunkgroup troncor2\r\ndestination-pattern Var19$\r\n progress_ind alert strip 8\r\n direct-inward-dial\r\n forward-digits 4\r\n!\r\ndial-peer voice 11 pots\r\n trunkgroup troncor2\r\n description PABX - Chamada a cobrar\r\n destination-pattern 90.T\r\n forward-digits 4\r\n!\r\ndial-peer voice 12 pots\r\n description OUTBOUND Tronco VIPLINE para rede publica\r\ndirect-inward-dial\r\n port portVoice\r\n!\r\n!\r\n!############### SIP Server ################\r\n!\r\nsip-ua \r\nsip-server ipv4:Var16\r\n!\r\n!\r\n!\r\n!############### Banner e User ################\r\n!\r\nbanner motd ^CCCCCC \r\n||========================================||\r\n||=============CLARO Brasil S.A.============||\r\n||========================================||\r\n!\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n!\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n!\r\n||========================================||^\r\n! \r\n!\r\n!\r\nline con 0\r\n no password\r\n login local\r\nline aux 0\r\n no password\r\n login local\r\nline vty 0 4\r\n no privilege level 15\r\n no password\r\n no access-class 23 in\r\n login local\r\n transport input all\r\n!\r\n!\r\n!\r\nend";
            #endregion
            // -------------------------------------------------------------------
            #region
            string ciscoR2ISR = "conf t\r\n!\r\n!\r\nhostname var00\r\n!\r\n!\r\n!\r\n!\r\nservice password encryption\r\nservice timestamps debug datetime msec\r\nservice timestamps log datetime msec\r\nno platform punt-keepalive disable-kernel-core\r\n!\r\n!\r\nboot-start-marker\r\nboot-end-marker\r\n!\r\nmultilink bundle-name authenticated\r\n!\r\n!\r\nno aaa new-model\r\n!\r\n!\r\n!\r\nspanning-tree extend system-id\r\n!\r\n!\r\n!\r\nusername EBT password CQMR\r\nenable secret PRO1AN\r\n!\r\n!\r\n!\r\nredundancy\r\n mode none\r\n!\r\n!\r\n!\r\n!\r\n!\r\n!\r\n!\r\nclass-map match-any Voz_RealIp\r\n match dscp cs3  ef\r\nclass-map match-any NetworkControl_RealIp\r\n match dscp cs2  cs6  cs7\r\n!\r\npolicy-map Voz_Ger\r\n class Voz_RealIp\r\npolicer rate bandaQoS000\r\n     conform-action transmit \r\n     exceed-action drop \r\n class NetworkControl_RealIp\r\n    bandwidth 63\r\n    queue-limit 32\r\n class class-default\r\n     random-detect\r\npolicy-map Saida_Voz\r\n class class-default\r\n shape average var02000\r\n  service-policy Voz_Ger\r\n!\r\n!\r\n!\r\n!\r\ninterface var03\r\ndescription var01\r\nband var02\r\n media-type rj45\r\n service-policy output Saida_Voz\r\nno shut\r\n!\r\n!\r\nwithVlan\r\n!\r\n!\r\n!\r\nip route 0.0.0.0 0.0.0.0 var07\r\n!\r\n!\r\n!\r\ntrunk group troncor2\r\n hunt-scheme sequential both down\r\n!\r\n!\r\ncard type e1 Var\r\n!\r\n!\r\nsubscriber templating\r\n!\r\n\r\n!\r\nvoice call send-alert\r\nvoice rtp send-recv\r\n!\r\nvoice class dscp-profile 1\r\n dscp media audio priority ef\r\n!\r\nvoice service voip\r\n ip address trusted list\r\n  ipv4 0.0.0.0 0.0.0.0\r\n allow-connections sip to sip\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n sip\r\nbind control source-interface var03\r\nbind media source-interface var03\r\n  no call service stop\r\n  dscp-profile 1\r\n!\r\nvoice class codec 1\r\n codec preference 1 g729r8\r\n codec preference 2 g711alaw\r\n codec preference 3 g729br8\r\n!\r\nvoice class sip-profiles 1\r\n response 503 sip-header Reason modify \"cause=3\" \"cause=41\"\r\n response 500 sip-header Reason modify \"cause=44\" \"cause=34\"\r\n response 404 sip-header Reason modify \"cause=3\" \"cause=34\"\r\n request CANCEL sip-header Reason modify \"cause=0\" \"cause=16\"\r\n request INVITE sip-header Remote-Party-ID remove\r\n request REINVITE sdp-header Audio-Connection-Info remove\r\n response 200 sdp-header Audio-Connection-Info remove\r\n response 183 sdp-header Audio-Connection-Info remove\r\n response 180 sdp-header Audio-Connection-Info remove\r\n response 200 method OPTIONS sdp-header Audio-Attribute remove\r\n response 200 sdp-header Audio-Attribute modify \"silenceSupp:off - - - -\" \"gpmd:8 vbd=yes\"\r\n request INVITE sdp-header Audio-Connection-Info remove\r\n!\r\n!\r\n!\r\n!  Exemplo de nº chave e faixa - (3186-6600 à 3186-6649)\r\nvoice translation-rule 10\r\nrule 1 /^\\(Var19\\)/ /\\1/\r\nrule 2 /^\\regraMCDU\\)/ /regra4Digitos\\1/\r\nrule 3 /^.*/ /Var17/\r\n!\r\n!\r\nvoice translation-profile EBT_BSOD\r\n translate calling 10\r\n!\r\n!\r\n!\r\n!\r\nsinalizacao\r\n!\r\n!\r\n!\r\n!\r\ndial-peer voice 10 pots\r\n port portVoice\r\n description INBOUND  Rede Publica para tronco Vipline\r\ndestination-pattern Var19$\r\n direct-inward-dial\r\n forward-digits 4\r\n!\r\ndial-peer voice 11 pots\r\n port portVoice\r\n description PABX - Chamada a cobrar\r\ndestination-pattern 9090Var19$\r\n direct-inward-dial\r\n forward-digits 4\r\n!\r\n!\r\n!\r\n!\r\ndial-peer voice 100 voip\r\n description Local\r\n huntstop\r\n destination-pattern [2-8].......\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 101 voip\r\n description Local a Cobrar\r\n huntstop\r\n destination-pattern 9090[2-8].......$\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 102 voip\r\n description Celular Local 9 dig\r\n huntstop\r\n destination-pattern 9........\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 103 voip\r\n description Celular Local 9 dig\r\n huntstop\r\n destination-pattern 90909........\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 104 voip\r\n description Longa Distancia\r\n huntstop\r\n destination-pattern 0[1-9].[1-9][1-9][2-8].......$\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 105 voip\r\n description Longa Distancia 9 dig\r\n huntstop\r\n destination-pattern 0[1-9].[1-9][1-9]9........\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 106 voip\r\n description Longa Distancia a cobrar\r\n huntstop\r\n destination-pattern 90[1-9].[1-9][1-9][2-8].......$\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 107 voip\r\n description Longa Distancia a cobrar Celular 9 dig\r\n huntstop\r\n destination-pattern 90[1-9].[1-9][1-9]9........\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 108 voip\r\n description Internacional\r\n huntstop\r\n destination-pattern 00.T\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 109 voip\r\n description Servico 0800 com 10 dig\r\n huntstop\r\n destination-pattern 0800.T\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 110 voip\r\n description Servico 0300\r\n huntstop\r\n destination-pattern 0300.......\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 111 voip\r\n description Servico 0500\r\n huntstop\r\n destination-pattern 0500.......\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 112 voip\r\n description Servico 0900\r\n huntstop\r\n destination-pattern 0900.......\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 113 voip\r\n description Servico Publico\r\n huntstop\r\n destination-pattern 1..T\r\n rtp payload-type cisco-codec-fax-ack 113\r\n rtp payload-type cisco-codec-fax-ind 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n playout-delay mode fixed no-timestamps\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n no vad\r\n!\r\ndial-peer voice 200 voip\r\n rtp payload-type cisco-codec-fax-ack 110\r\n rtp payload-type nse 102\r\n rtp payload-type nte 97\r\n modem passthrough nse codec g711alaw\r\n session protocol sipv2\r\n session target sip-server\r\n incoming called-number .T\r\n voice-class codec 1\r\n voice-class sip asserted-id pai\r\n voice-class sip profiles 1\r\n dtmf-relay rtp-nte\r\n fax protocol t38 version 0 ls-redundancy 0 hs-redundancy 0 fallback pass-through g711alaw\r\n ip qos dscp cs3 signaling\r\n!\r\n!\r\n!\r\nsip-ua\r\n set sip-status 410 pstn-cause 22\r\n set pstn-cause 3 sip-status 503\r\n set pstn-cause 31 sip-status 480\r\n retry invite 5\r\n timers expires 120000\r\nsip-server ipv4:Var16:5060\r\n!\r\n!\r\nnetwork-clock synchronization automatic\r\nnetwork-clock input-source 1 controller E1 Var21\r\n!\r\n!\r\n!\r\nbanner motd ^CCCCCC \r\n||========================================||\r\n||========== CLARO Brasil S.A. ===========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||^\r\n! \r\n!\r\nline con 0\r\n stopbits 1\r\nline aux 0\r\n stopbits 1\r\nline vty 0 4\r\n login local\r\n transport input all\r\n!\r\n!\r\n!\r\nend\r\n\r\n";
            #endregion
            // -------------------------------------------------------------------
            #region
            string ciscoPABX = "conf t \r\n!\r\n!\r\nhostname var00\r\n!\r\nip domain name embratel \r\n!\r\n!\r\n###################################################### \r\n# CONFIGURACOES DE USUARIO # \r\n###################################################### \r\n!\r\nservice password-encryption\r\nusername EBT privilege 10 password 0 CQMR\r\nenable secret PRO1AN\r\nlogging buffered 4096 debugging\r\n!\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# LIMPEZA \r\n!###################################################### \r\n!\r\nno ip domain name yourdomain.com \r\nno ip domain lookup \r\n!\r\n!\r\nconfig-register 0x2102\r\nno username cisco\r\nno username admin\r\n!\r\n!\r\nno ip dhcp excluded-address 10.10.10.1 \r\nno ip dhcp pool ccp-pool \r\n!\r\n!\r\nno ip ssh version 1 \r\nip ssh version 2 \r\n!\r\n!\r\nno boot host \r\nno boot network  \r\n!\r\n!\r\nno ip finger \r\nno service pad \r\nno service tcp-small-servers \r\nno ip bootp server \r\nno ip source-route \r\nno cdp run \r\n!\r\n!\r\nno access-list 23 permit 10.10.10.0 0.0.0.7 \r\n!\r\n!\r\nno ip http server\r\nno ip http secure-server\r\nno ip http access-class 23\r\nno ip http authentication local\r\nno ip http timeout-policy idle 60 life 86400 requests 10000\r\nlogging buffered 51200 warnings \r\nno logging console \r\nno logging trap notifications\r\n!\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# POLICY MAP - QoS \r\n!###################################################### \r\n!\r\nclass-map match-any Voz_RealIp\r\n match  dscp cs3  ef \r\nclass-map match-any NetworkControl_RealIp\r\n match  dscp cs2  cs6  cs7 \r\nclass-map match-any MarcacaoVoz\r\n match any\r\n!\r\npolicy-map EntradaLanCE\r\n class MarcacaoVoz\r\n  set ip dscp ef\r\npolicy-map Voz_Ger\r\n class Voz_RealIp\r\npolice rate bandaQoS000\r\n     conform-action transmit \r\n     exceed-action drop \r\n    priority\r\n class NetworkControl_RealIp\r\n    bandwidth 63\r\n    queue-limit 32 packets\r\n class class-default\r\n     random-detect\r\npolicy-map Saida_Voz\r\n class class-default\r\n shape average var02000\r\n  service-policy Voz_Ger\r\n!\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# CONFIGURACOES DE INTERFACES \r\n!###################################################### \r\n!\r\nInterface var03\r\ndescription var01\r\nbandwidth var02\r\n service-policy output Saida_Voz\r\nno shut\r\n!\r\n!\r\n!\r\nwithVlan\r\n!\r\n!\r\n!\r\ninterface var05\r\n description *** REDE LAN - PORTA DE CONEXAO COM PABX IP ***\r\nip address var09 mascaraLAN\r\n duplex auto\r\n speed auto\r\n service-policy input EntradaLanCE\r\n no shut\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# ROTA ESTATICA \r\n!###################################################### \r\n!\r\nip route 0.0.0.0 0.0.0.0 var07\r\n!\r\n!\r\n!\r\n!\r\n!###################################################### \r\n!# BANNER - USER INTERFACE \r\n!###################################################### \r\n!\r\n!\r\nbanner motd ^\r\n||========================================||\r\n||========== CLARO Brasil S.A. ===========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||^\r\n!\r\n!\r\nno banner exec ^\r\nno banner login ^\r\n!\r\n!\r\n!\r\nline con 0\r\n no password\r\n login local\r\nline aux 0\r\n no password\r\n login local\r\nline vty 0 4\r\n no privilege level 15\r\n no password\r\n no access-class 23 in\r\n login local\r\n transport input all\r\nno line vty 5 15\r\n!\r\n!\r\n!\r\n!\r\nend\r\n";
            #endregion
            // ------------------------------------------- Config - HPE - VOZ --------------------------------------------------------
            #region
            string hpeR2 = "sys\r\n#\r\nsysname var00\r\n#\r\n#\r\n############### Usuarios ################\r\n#\r\npassword-recovery enable\r\n# \r\nlocal-user EBT class manage\r\npassword simple PRO1AN\r\nPRO1AN\r\nservice-type telnet terminal\r\nauthorization-attribute user-role level-15\r\nauthorization-attribute user-role network-admin\r\nauthorization-attribute user-role network-operator \r\n#\r\n#\r\n#\r\n#\r\n############### Limpeza ################\r\n#\r\ndomain default enable system\r\n#\r\ntelnet server enable\r\n#\r\nundo ip http enable\r\n#\r\ninterface Vlan-interface1\r\nundo ip address\r\nundo snmp-agent\r\nundo nqa entry imclinktopologypleaseignore ping\r\nundo nqa schedule imclinktopologypleaseignore ping\r\nundo interface Vlan-interface1\r\n#\r\n#\r\nundo dhcp enable\r\nundo dhcp server ip-pool lan1\r\nundo dhcp server always-broadcast\r\n#\r\nundo dns proxy enable\r\n#\r\ninterface GigabitEthernet0/0\r\nundo ip address dhcp-alloc\r\n#\r\n#\r\nundo local-user admin class manage\r\n#\r\n#\r\n#\r\n############### QoS ################\r\n#\r\ntraffic classifier NetworkControl operator and\r\n if-match dscp cs2 cs6 cs7\r\ntraffic classifier voz operator and\r\n if-match dscp ef\r\ntraffic classifier class_default operator and\r\ntraffic classifier Sinaliz-SIP operator and\r\n if-match dscp cs3\r\n#\r\ntraffic behavior NetworkControl\r\n queue af bandwidth pct 2\r\ntraffic behavior voz\r\n queue ef bandwidth pct 93 cbs-ratio 25\r\ntraffic behavior class_default\r\n gts cir var02000\r\n remark dscp default\r\ntraffic behavior Sinaliz-SIP\r\n queue af bandwidth pct 4\r\n#\r\nqos policy SHAPE-OUT\r\n classifier voz behavior voz\r\n classifier Sinaliz-SIP behavior Sinaliz-SIP\r\n classifier class_default behavior class_default\r\n classifier NetworkControl behavior NetworkControl\r\n#\r\n#\r\n#\r\n#\r\n############### Interface ################\r\n#\r\nInterface var03\r\nport link-mode route\r\ndescription var01\r\nbandwidth var02\r\nqos max-bandwidth var02\r\nundo virtualbaudrate\r\nqos apply policy SHAPE-OUT outbound\r\n#\r\n#\r\nwithVlan\r\n#\r\n#\r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var07\r\n#\r\n#\r\n#\r\n#\r\n############### SIP ################\r\n#\r\nvoice-setup\r\n cptone country-type BR\r\n cptone tone-type dial-tone amplitude 1500\r\n#\r\n#\r\nsip\r\nrel1xx disable\r\nproxy ip Var16 port 5060\r\nip qos dscp ef media\r\nip qos dscp cs3 signaling\r\n#\r\n voice class codec 1\r\n  codec preference 1 g729a bytes 20\r\n  codec preference 2 g729br8 bytes 20\r\n  codec preference 3 g729r8 bytes 20\r\n  codec preference 4 g711alaw\r\n#\r\n#\r\n#\r\ndial-program\r\nterminator #\r\n  number-match longest\r\n#\r\n#\r\n#\r\n#\r\n############### Regras de Saída ################\r\n#\r\nnumber-substitute 100\r\ndot-match left-right\r\nrule 1 ^SaidaRegra$ SaidaRegra\r\nrule 2 ^SaidaMCDU$ SaidaRegra\r\nrule 3 ^....$ Var17\r\nrule 4 ^........$ Var17\r\n#\r\n#\r\n#\r\n#\r\n############### VOIPs ################\r\n#\r\nentity 100 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template [2-8].......\r\ndescription Local\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 101 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 9090[2-9].......\r\ndescription Local a Cobrar\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 102 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 9........\r\ndescription Celular Local 9 dig\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 103 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 90909........\r\ndescription Celular a cobrar 9 dig\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 104 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 0[1-9].[1-9][1-9][2-8].......\r\ndescription Longa Distância\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 105 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 0[1-9].[1-9][1-9]9........\r\ndescription Longa Distância 9 dig\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 106 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 90[1-9].[1-9][1-9][2-8].......\r\ndescription Longa Distância a cobrar\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 107 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 90[1-9].[1-9][1-9]9........\r\ndescription Longa Distância a cobrar Celular 9 dig\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\n#\r\nentity 108 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 00.T\r\ndescription Internacional\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\n#\r\nentity 109 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 0800......T\r\ndescription Serviço 0800\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 111 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 0300.......\r\ndescription Serviço 0300\r\noutband nte\r\nvoice-class codec 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 112 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 0500.......\r\ndescription Serviço 0500\r\noutband nte\r\nvoice-class codec 1\r\n#\r\nentity 113 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 0900.......\r\ndescription Serviço 0900\r\noutband nte\r\nvoice-class codec 1\r\n#\r\nentity 114 voip\r\naddress sip proxy\r\nsession transport udp\r\nmatch-template 1..T\r\ndescription Serviço Público\r\noutband nte\r\nvoice-class codec 1\r\n#\r\nentity 888 voip  \r\naddress sip proxy\r\nsession transport udp\r\ndescription GENERICO\r\noutband nte\r\nvoice-class codec 1\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\n#\r\n#\r\n#\r\n############### SINALIZACAO ################\r\n#\r\nsinalizacao\r\n#\r\n#\r\n#\r\n#\r\n############### POTS - Entrada ################\r\n#\r\nvoice-setup\r\n#\r\ndial-program\r\n#\r\n#\r\nentity 10 pots\r\nline portaV\r\nsend-number 4\r\ndescription Ramais PABX\r\nmatch-template Var19\r\nvoice-class codec 1\r\noutband nte\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 11 pots\r\nline portaV\r\nsend-number 4\r\ndescription PABX - Chamada a cobrar\r\nmatch-template 9090Var19\r\nvoice-class codec 1\r\noutband nte\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity 12 pots\r\nline portaV\r\nsend-number 4\r\ndescription PABX - Chamada a cobrar Longa Distancia\r\nmatch-template 9021Var18Var19\r\nvoice-class codec 1\r\noutband nte\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\n#\r\n#\r\n#\r\n############### SUBSCRIBER ################\r\n#\r\nsubscriber-lineportaV\r\n undo cng-on\r\n undo echo-canceler enable\r\n ReverseR2\r\n substitute calling 100\r\n#\r\n#\r\n#\r\n#\r\n############### Banner e User ################\r\n#\r\nheader motd %\r\n#\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n%\r\n#\r\nline class aux\r\n user-role network-admin\r\n#\r\nline class tty\r\n user-role network-operator\r\n#\r\nline class vty\r\n user-role network-operator\r\n#\r\nline aux 0\r\n user-role network-admin\r\n#\r\nline vty 0 4\r\n authentication-mode scheme\r\n user-role level-15\r\n user-role network-admin\r\n user-role network-operator\r\n idle-timeout 0 0\r\n#\r\nline vty 5 63\r\n user-role network-operator\r\ndomain system\r\nundo interface Vlan-interface1\r\n#\r\nreturn";
            #endregion
            // -------------------------------------------------------------------
            #region
            string hpePABX = $"system-view \r\n#\r\nsysname var00\r\n# \r\n# \r\n###################################################### \r\n# CONFIGURACOES DE USUARIO # \r\n######################################################\r\n#\r\nlocal-user EBT\r\npassword simple PRO1AN\r\nauthorization-attribute level 3\r\nservice-type telnet\r\n#\r\n#\r\n#\r\n###################################################### \r\n# LIMPEZA # \r\n###################################################### \r\n#\r\nundo local-user admin class manage\r\nundo snmp-agent\r\n#\r\n#\r\n\"service-type telnet terminal\r\n\"service-type ftp\r\n\"telnet server enable\r\n\"password-recovery enable\r\n\"info-center logbuffer size 1024\r\nundo interface Vlan-interface1\r\n#\r\n#\r\nundo dhcp enable\r\nundo dhcp server always-broadcast\r\nundo dhcp server ip-pool lan1\r\nundo dns proxy enable\r\n#\r\n#\r\ntelnet server enable\r\n#\r\n#\r\ndomain system\r\naccess-limit disable\r\nstate active\r\nidle-cut disable\r\nself-service-url disable\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE QoS # \r\n###################################################### \r\n#\r\ntraffic classifier class_default operator and\r\n if-match any\r\ntraffic classifier voz operator and\r\n if-match dscp ef\r\ntraffic classifier NetworkControl operator and\r\n if-match dscp cs2 cs6 cs7\r\ntraffic classifier ClassificaVoz operator and\r\n if-match any\r\n#\r\ntraffic behavior voz\r\nqueue ef bandwidth bandaQos000\r\ntraffic behavior NetworkControl\r\n queue af bandwidth 63\r\ntraffic behavior RemarkVoz\r\n remark dscp ef\r\n#\r\nqos policy Voz_Ger\r\n classifier voz behavior voz\r\n classifier NetworkControl behavior NetworkControl\r\n#\r\ntraffic behavior class_default\r\n gts cir var02\r\n traffic-policy Voz_Ger\r\n#\r\n#\r\nqos policy Saida_Voz\r\n classifier class_default behavior class_default\r\n#\r\nqos policy EntradaLanCE\r\n classifier ClassificaVoz behavior RemarkVoz\r\n#\r\n#\r\n#\r\n###################################################### \r\n# CONFIGURACOES DE INTERFACES # \r\n###################################################### \r\n#\r\ninterface var03\r\ndescription  var01\r\nport link-mode route\r\nundo virtualbaudrate\r\nbandwidth var02\r\nqos apply policy Saida_Voz outbound\r\n#\r\n#\r\n#\r\ninterface var03.var04\r\nvlan-type dot1q vid var04\r\ndescription  var01\r\nbandwidth var02\r\n#\r\n#\r\n#\r\ninterface var05\r\n port link-mode route\r\ndescription *** REDE LAN - PORTA DE CONEXAO COM PABX IP ***\r\nip address var09 mascaraLAN\r\nqos apply policy EntradaLanCE inbound\r\nundo shut\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# ROTA ESTATICA # \r\n###################################################### \r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var07\r\n#\r\n#\r\n#\r\n#\r\n#\r\n###################################################### \r\n# BANNER - USER INTERFACE \r\n###################################################### \r\n#\r\nuser-interface con 0\r\nuser-interface tty 13\r\nuser-interface aux 0\r\nuser-interface vty 0 4\r\nauthentication-mode scheme\r\n#\r\n#\r\nheader motd %\r\n||========================================||\r\n||=============CLARO Brasil S.A.==========||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n%\r\n#\r\n#\r\n# \r\nreturn\r\n";
            #endregion
            // ------------------------------------------- Config - HPE Old - VOZ ----------------------------------------------------
            #region
            string hpeOldR2 = "sys\r\n#\r\nsysname var00\r\n#\r\n#\r\n############### Usuarios ################\r\n#\r\npassword-recovery enable\r\n#\r\nlocal-user EBT\r\npassword simple PRO1AN\r\nPRO1AN\r\nauthorization-attribute level 3\r\nservice-type telnet\r\nundo local-user admin\r\n#\r\n#\r\n#\r\n############### Limpeza ################\r\n#\r\ndomain default enable system\r\n#\r\ntelnet server enable\r\n#\r\nundo ip http enable\r\n#\r\ninterface Vlan-interface1\r\nundo ip address\r\nundo snmp-agent\r\nundo nqa entry imclinktopologypleaseignore ping\r\nundo nqa schedule imclinktopologypleaseignore ping\r\nundo interface Vlan-interface1\r\n#\r\n#\r\n#\r\n############### QoS ################\r\n#\r\ntraffic classifier NetworkControl operator and\r\n if-match dscp cs2 cs6 cs7\r\ntraffic classifier voz operator and\r\n if-match dscp ef\r\ntraffic classifier class_default operator and\r\ntraffic classifier Sinaliz-SIP operator and\r\n if-match dscp cs3\r\n#\r\ntraffic behavior NetworkControl\r\n queue af bandwidth pct 2\r\ntraffic behavior voz\r\n queue ef bandwidth pct 93 cbs-ratio 25\r\ntraffic behavior class_default\r\n gts cir var02000\r\n remark dscp default\r\ntraffic behavior Sinaliz-SIP\r\n queue af bandwidth pct 4\r\n#\r\n#\r\nqos policy SHAPE-OUT\r\n classifier voz behavior voz\r\n classifier Sinaliz-SIP behavior Sinaliz-SIP\r\n classifier class_default behavior class_default\r\n classifier NetworkControl behavior NetworkControl\r\n#\r\n#\r\n#\r\n############### Interface ################\r\n#\r\nInterface var03\r\nport link-mode route\r\ndescription var01\r\nbandwidth var02\r\nqos max-bandwidth var02\r\nundo virtualbaudrate\r\nqos apply policy SHAPE-OUT outbound\r\n#\r\n#\r\nwithVlan\r\n#\r\n#\r\nip route-static 0.0.0.0 0.0.0.0 var07\r\n#\r\n#\r\n############### SIP ################\r\n#\r\nvoice-setup\r\n cptone country-type BR\r\n cptone tone-type dial-tone amplitude 1500\r\n#\r\nsip\r\nproxy ipv4 Var16 port 5060\r\nkeepalive options interval 5\r\n#\r\nsip-server\r\n#\r\ncall-rule-set\r\n#\r\ncall-route\r\n#\r\ndial-program\r\n  default entity compression 2nd-level  g729br8\r\n  default entity compression 3rd-level  g711alaw\r\n  default entity compression 4th-level  g729r8\r\ndefault entity fax protocol standard-t38\r\ndefault entity fax protocol standard-t38 hb-redundancy 0\r\ndefault entity fax protocol standard-t38 lb-redundancy 0\r\ndefault entity modem protocol pcm standard g711alaw\r\ndefault entity payload-size g729 20\r\nterminator #\r\nnumber-match longest\r\nnumber-priority peer enable\r\n#\r\n#\r\n#\r\n############### Regras de Saída ################\r\n#\r\nnumber-substitute 100\r\ndot-match left-right\r\nrule 1 ^SaidaRegra$ SaidaRegra\r\nrule 2 ^SaidaMCDU$ SaidaRegra\r\nrule 3 ^....$ Var17\r\nrule 4 ^........$ Var17\r\n#\r\n#\r\n#\r\n############### VOIPs ################\r\n#\r\nentity 100 voip\r\naddress sip proxy\r\ndescription LONGA_DISTANCIA\r\nmatch-template 0[1-9].[1-9][1-9][2-8].......\r\noutband nte\r\n#\r\nentity 101 voip\r\naddress sip proxy\r\ndescription LONGA_DISTANCIA_9\r\nmatch-template 0[1-9].[1-9][1-9]9........\r\noutband nte\r\n#\r\nentity 102 voip\r\naddress sip proxy\r\ndescription A_COBRAR_LOCAL\r\nmatch-template 9090[2-8].......\r\noutband nte\r\n#\r\nentity 103 voip\r\naddress sip proxy\r\ndescription A_COBRAR_LONGA_DISTANCIA\r\nmatch-template 90[1-9].[1-9][1-9][2-8].......\r\noutband nte\r\n#\r\nentity 104 voip\r\naddress sip proxy\r\ndescription ZERO_800\r\nmatch-template 0800......T\r\noutband nte\r\n#\r\nentity 105 voip\r\naddress sip proxy\r\ndescription ZERO_300\r\nmatch-template 0300......T\r\noutband nte\r\n#\r\nentity 106 voip\r\naddress sip proxy\r\ndescription INTERNACIONAL\r\nmatch-template 00.T\r\noutband nte\r\n#\r\nentity 107 voip\r\naddress sip proxy\r\ndescription Servicos Publicos\r\nmatch-template 1..T\r\noutband nte\r\n#\r\nentity 108 voip\r\naddress sip proxy\r\ndescription LOCAL CELULAR\r\nmatch-template 9........\r\noutband nte\r\n#\r\nentity 109 voip\r\naddress sip proxy\r\ndescription IG  Provedores\r\nmatch-template 1[5-9]......\r\noutband nte\r\n#\r\nentity 110 voip\r\naddress sip proxy\r\ndescription ZERO_500\r\nmatch-template 0500......T\r\noutband nte\r\n#\r\nentity 114 voip\r\naddress sip proxy\r\ndescription A_COBRAR_LONGA_DISTANCIA_9\r\nmatch-template 90[1-9].[1-9][1-9]9........\r\noutband nte\r\n#\r\nentity 116 voip\r\naddress sip proxy\r\ndescription A_COBRAR_LOCAL_9 digito SP\r\nmatch-template 90909........\r\noutband nte\r\n#\r\n#\r\n#\r\nentity 118 voip\r\naddress sip proxy\r\ndescription LOCAL\r\nmatch-template [2-6].......\r\noutband nte\r\n#\r\nentity 119 voip\r\naddress sip proxy\r\ndescription Longa_Distancia_Servicos_Publicos\r\nmatch-template 0[1-9].[1-9][1-9]1..T\r\noutband nte\r\n#\r\nentity 120 voip\r\naddress sip proxy\r\ndescription Servicos_Publicos\r\nmatch-template 19.\r\noutband nte\r\n#\r\n#\r\n#\r\n############### SINALIZACAO ################\r\n#\r\nsinalizacao\r\n#\r\n#\r\n#\r\n############### POTS - Entrada ################\r\n#\r\nvoice-setup\r\n#\r\ndial-program\r\n#\r\nentity 10 pots\r\nline portaV\r\nsend-number 4\r\ndescription Ramais PABX\r\nmatch-template Var19\r\nsend-ring\r\noutband nte\r\n#\r\nentity 11 pots\r\nline portaV\r\nsend-number 4\r\ndescription PABX - Chamada a cobrar\r\nmatch-template 9090Var19\r\nsend-ring\r\noutband nte\r\n#\r\nentity 12 pots\r\nline portaV\r\nsend-number 4\r\ndescription PABX - Chamada a cobrar Longa Distancia\r\nmatch-template 9021Var18Var19\r\nsend-ring\r\noutband nte\r\n#\r\n#\r\n############### SUBSCRIBER ################\r\n#\r\nsubscriber-lineportaV\r\nundo cng-on\r\necho-canceller enable\r\ndtmf threshold digital 1\r\nsubstitute calling 100\r\nhunt-group enable\r\n#\r\n#\r\n#\r\n############### Banner e User ################\r\n#\r\nheader motd %\r\n||========================================||\r\n||=============CLARO Brasil S.A.============||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||\r\n%\r\n#\r\n#\r\nuser-interface aux 0\r\nuser-interface vty 0 4\r\nauthentication-mode scheme\r\n#\r\n#\r\n#\r\nreturn\r\n";
            #endregion
            // ------------------------------------------- Config - Aligera - VOZ ----------------------------------------------------
            #region
            string aligera561 = "!###########################\r\n!GW, HOSTNAME E USER\r\n!###########################\r\nconfig login user EBT privilege_level admin\r\nconfig login user EBT password\r\nPRO1AN\r\nPRO1AN\r\n!\r\nconfig network ip defaultgw var07\r\nconfig network hostname var00\r\n!###########################\r\n!CONFIGURA A PORTA EM 100FULL\r\n!###########################\r\nconfig network switch port1 mode 100full\r\n!\r\n!###########################\r\n!CONFIGURAÇAO DA E1 R2\r\n!###########################\r\n!\r\nsinalizacao\r\n!\r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!############################\r\n!CONFIGURAÇAO DO SIP SERVER\r\n!############################\r\n!\r\nconfig sip prack yes\r\nconfig sip tos_sip 24\r\nconfig sip tos_rtp 46\r\nconfig sip vad yes\r\nconfig sip dtmf_rtp_pt 97\r\nconfig sip peer trunk1 host Var16\r\nconfig sip peer trunk1 port 5060\r\nconfig sip peer trunk1 dtmfmode rfc2833\r\nconfig sip peer trunk1 t38 yes\r\nconfig sip peer trunk1 codecs g729 alaw\r\nconfig sip peer trunk1 force180sdp yes\r\n!\r\n!#####################################\r\n!LIMPEZA DAS REGRAS EXISTENTES\r\n!#####################################\r\n!\r\nconfig dialplan rule sip_trunk1_default delete\r\nconfig dialplan rule tdm_group1_default delete\r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!############################\r\n!REGRAS PARA CHAMADAS DE ENTRADA\r\n!############################ \r\n!\r\nconfig dialplan rule from_sip_local source_peer sip trunk1\r\nconfig dialplan rule from_sip_local destination_peer tdm group1\r\nconfig dialplan rule from_sip_local called_pattern Var19\r\nconfig dialplan rule from_sip_local outgoing_called {:-4}   \r\n!\r\nconfig dialplan rule from_sip_a_cobrar source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar called_pattern 9090Var19\r\nconfig dialplan rule from_sip_a_cobrar outgoing_called {:-4}\r\n!\r\nconfig dialplan rule from_sip_a_cobrar_ldn source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar_ldn destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar_ldn called_pattern 9021Var18Var19\r\nconfig dialplan rule from_sip_a_cobrar_ldn outgoing_called {:-4}  \r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n############################\r\nREGRAS PARA CHAMADAS DE SAINTES\r\n############################ \r\n\r\nconfig dialplan rule from_tdm_local_8d_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_1 called_pattern [2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_2 called_pattern [2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_3 called_pattern [2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_local_8d_cobrar_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_1 called_pattern 9090[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_cobrar_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_2 called_pattern 9090[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_cobrar_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_3 called_pattern 9090[2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_celular_local_9d_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_1 called_pattern 9XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_2 called_pattern 9XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_3 called_pattern 9XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_1 called_pattern 90909XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_2 called_pattern 90909XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_3 called_pattern 90909XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_8d_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_1 called_pattern 0ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_2 called_pattern 0ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_3 called_pattern 0ZXZZ[2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_9d_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_1 called_pattern 0ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_2 called_pattern 0ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_3 called_pattern 0ZXZZ9XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 called_pattern 90ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 called_pattern 90ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 called_pattern 90ZXZZ[2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_1 called_pattern 90ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_2 called_pattern 90ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_3 called_pattern 90ZXZZ9XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_internacional_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_internacional_1 called_pattern 00X.\r\nconfig dialplan rule from_tdm_internacional_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_internacional_2 called_pattern 00X.\r\nconfig dialplan rule from_tdm_internacional_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_internacional_3 called_pattern 00X.\r\n\r\nconfig dialplan rule from_tdm_0800_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0800_1 called_pattern 0800X.\r\nconfig dialplan rule from_tdm_0800_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0800_2 called_pattern 0800X.\r\nconfig dialplan rule from_tdm_0800_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0800_3 called_pattern 0800X.\r\n\r\nconfig dialplan rule from_tdm_0300_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0300_1 called_pattern 0300XXXXXXX\r\nconfig dialplan rule from_tdm_0300_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0300_2 called_pattern 0300XXXXXXX\r\nconfig dialplan rule from_tdm_0300_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0300_3 called_pattern 0300XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_0500_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0500_1 called_pattern 0500XXXXXXX\r\nconfig dialplan rule from_tdm_0500_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0500_2 called_pattern 0500XXXXXXX\r\nconfig dialplan rule from_tdm_0500_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0500_3 called_pattern 0500XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_0900_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0900_1 called_pattern 0900XXXXXXX\r\nconfig dialplan rule from_tdm_0900_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0900_2 called_pattern 0900XXXXXXX\r\nconfig dialplan rule from_tdm_0900_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0900_3 called_pattern 0900XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_serv_pub_emerg_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_1 called_pattern 19X\r\nconfig dialplan rule from_tdm_serv_pub_emerg_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_2 called_pattern 19X\r\nconfig dialplan rule from_tdm_serv_pub_emerg_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_3 called_pattern 19X\r\n\r\nconfig dialplan rule from_tdm_serv_pub_1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_1 called_pattern 1[0-8].\r\nconfig dialplan rule from_tdm_serv_pub_2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_2 called_pattern 1[0-8].\r\nconfig dialplan rule from_tdm_serv_pub_3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_3 called_pattern 1[0-8].\r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!############################\r\n!REGRAS PARA MANIPULAÇAO DO NUMERO DE A\r\n!############################ \r\n!\r\nconfig dialplan rule from_tdm_local_8d_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_local_8d_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_local_8d_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_local_8d_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_local_8d_3 callerid_pattern\r\nconfig dialplan rule from_tdm_local_8d_3 outgoing_callerid Var18Var17\r\n!\r\nconfig dialplan rule from_tdm_local_8d_cobrar_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_local_8d_cobrar_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_local_8d_cobrar_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_local_8d_cobrar_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_local_8d_cobrar_3 callerid_pattern\r\nconfig dialplan rule from_tdm_local_8d_cobrar_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_celular_local_9d_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_celular_local_9d_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_celular_local_9d_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_celular_local_9d_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_celular_local_9d_3 callerid_pattern\r\nconfig dialplan rule from_tdm_celular_local_9d_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_3 callerid_pattern\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_ldn_8d_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_8d_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_8d_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_ldn_8d_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_8d_3 callerid_pattern \r\nconfig dialplan rule from_tdm_ldn_8d_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_ldn_9d_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_9d_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_9d_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_ldn_9d_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_9d_3 callerid_pattern \r\nconfig dialplan rule from_tdm_ldn_9d_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_internacional_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_internacional_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_internacional_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_internacional_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_internacional_3 callerid_pattern\r\nconfig dialplan rule from_tdm_internacional_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_0800_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0800_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0800_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_0800_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0800_3 callerid_pattern\r\nconfig dialplan rule from_tdm_0800_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_0300_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0300_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0300_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_0300_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0300_3 callerid_pattern\r\nconfig dialplan rule from_tdm_0300_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_0500_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0500_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0500_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_0500_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0500_3 callerid_pattern\r\nconfig dialplan rule from_tdm_0500_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_0900_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0900_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0900_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_0900_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0900_3 callerid_pattern\r\nconfig dialplan rule from_tdm_0900_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_serv_pub_emerg_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_serv_pub_emerg_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_serv_pub_emerg_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_serv_pub_emerg_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_serv_pub_emerg_3 callerid_pattern\r\nconfig dialplan rule from_tdm_serv_pub_emerg_3 outgoing_callerid Var17\r\n!\r\nconfig dialplan rule from_tdm_serv_pub_1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_serv_pub_1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_serv_pub_2 callerid_pattern Var19\r\nconfig dialplan rule from_tdm_serv_pub_2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_serv_pub_3 callerid_pattern\r\nconfig dialplan rule from_tdm_serv_pub_3 outgoing_callerid Var17\r\n!\r\nconfig apply\r\nconfig save\r\n!";
            #endregion
            // -------------------------------------------------------------------
            #region
            string aligera1600 = "!###########################\r\n!GW E HOSTNAME\r\n!###########################\r\nconfig login user EBT privilege_level admin\r\nconfig login user EBT password\r\nPRO1AN\r\nPRO1AN\r\n#\r\nconfig network defaultgw var07\r\n!###########################\r\n!CONFIGURA A PORTA EM 100FULL\r\n!###########################\r\nconfig network switch port1 mode 100full\r\nconfig network switch port2 mode 100full\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\nconfig network hostname var00\r\n#\r\n##### 7.1 Configuração para atendimento a R2 #####\r\n#\r\nsinalizacao\r\n#\r\n#\r\n#\r\nconfig save\r\nconfig apply\r\n#\r\n# É necessário repetir essa sequência de comandos para cada uma das interfaces E1, substituindo port1 pela interface que se deseja configurar, sendo as demais portas nomeadas como port2... port3...\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n\r\n##### 7.3 Configurações SIP #####\r\n\r\nconfig sip prack yes\r\nconfig sip tos_sip 96\r\nconfig sip tos_rtp 194\r\nconfig sip dtmf_rtp_pt 97\r\nconfig sip session_expires 3600\r\nconfig sip peer trunk1 host Var16\r\nconfig sip peer trunk1 port 5060\r\nconfig sip peer trunk1 dtmfmode rfc2833\r\nconfig sip peer trunk1 t38 yes\r\nconfig sip peer trunk1 codecs g729 alaw\r\nconfig sip peer trunk1 options_keepalive yes\r\nconfig sip peer trunk1 call_limit 60\r\nconfig sip peer trunk1 force180sdp yes\r\n#\r\nconfig save\r\nconfig apply\r\n#\r\n##### 7.4 Configurações de dialplan #####\r\nconfig dialplan rule sip_trunk1_default delete\r\nconfig dialplan rule tdm_group1_default delete\r\n#\r\n##### Plano de Encaminhamento para chamadas terminadas no PABX: #####\r\nconfig dialplan rule from_sip_local source_peer sip trunk1\r\nconfig dialplan rule from_sip_local destination_peer tdm group1\r\nconfig dialplan rule from_sip_local called_pattern Var19\r\nconfig dialplan rule from_sip_local outgoing_called {:-4}  \r\n\r\nconfig dialplan rule from_sip_a_cobrar source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar called_pattern 9090Var19\r\nconfig dialplan rule from_sip_a_cobrar outgoing_called {:-4} \r\n\r\nconfig dialplan rule from_sip_ldn source_peer sip trunk1\r\nconfig dialplan rule from_sip_ldn destination_peer tdm group1\r\nconfig dialplan rule from_sip_ldn called_pattern 021Var18Var19\r\nconfig dialplan rule from_sip_ldn outgoing_called {:-4}  \r\n\r\nconfig dialplan rule from_sip_a_cobrar_ldn source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar_ldn destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar_ldn called_pattern 9021Var18Var19\r\nconfig dialplan rule from_sip_a_cobrar_ldn outgoing_called {:-4}  \r\n\r\n##### Plano de Encaminhamento para chamadas terminadas no PSTN: #####\r\n\r\nconfig dialplan rule from_tdm_local_8d source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_local_8d called_pattern [2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_local_8d_cobrar source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_local_8d_cobrar called_pattern 9090[2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_celular_local_9d source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_celular_local_9d called_pattern 9XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar called_pattern 90909XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_8d source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_ldn_8d called_pattern 0ZXZZ[2-8]XXXXXXX\r\n\r\n\r\nconfig dialplan rule from_tdm_ldn_9d source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_ldn_9d called_pattern 0ZXZZ9XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar called_pattern 90ZXZZ[2-8]XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar called_pattern 90ZXZZ9XXXXXXXX\r\n\r\nconfig dialplan rule from_tdm_internacional source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_internacional called_pattern 00X.\r\n\r\nconfig dialplan rule from_tdm_0800 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800 destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_0800 called_pattern 0800X.\r\n\r\nconfig dialplan rule from_tdm_0300 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300 destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_0300 called_pattern 0300XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_0500 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500 destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_0500 called_pattern 0500XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_0900 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900 destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_0900 called_pattern 0900XXXXXXX\r\n\r\nconfig dialplan rule from_tdm_serv_pub_emerg source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_serv_pub_emerg called_pattern 19X\r\n\r\nconfig dialplan rule from_tdm_serv_pub source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub destination_peer local from_tdm\r\nconfig dialplan rule from_tdm_serv_pub called_pattern 1[0-8].\r\n#\r\n##### Configuração das manipulações do número de A enviado pelo PABX: #####\r\n#\r\nconfig dialplan rule to_sip_1 source_peer local from_tdm\r\nconfig dialplan rule to_sip_1 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_1 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_1 called_pattern X.\r\nconfig dialplan rule to_sip_1 callerid_pattern\r\nconfig dialplan rule to_sip_1 outgoing_called {}\r\nconfig dialplan rule to_sip_1 outgoing_callerid Var17\r\nconfig dialplan rule to_sip_1 answer_timeout 90\r\nconfig dialplan rule to_sip_1 duration_limit 0\r\n#\r\nconfig dialplan rule to_sip_2 source_peer local from_tdm\r\nconfig dialplan rule to_sip_2 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_2 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_2 called_pattern X.\r\nconfig dialplan rule to_sip_2 callerid_pattern Var19\r\nconfig dialplan rule to_sip_2 outgoing_called {}\r\nconfig dialplan rule to_sip_2 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule to_sip_2 answer_timeout 90\r\nconfig dialplan rule to_sip_2 duration_limit 0\r\n#\r\nconfig dialplan rule to_sip_3 source_peer local from_tdm\r\nconfig dialplan rule to_sip_3 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_3 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_3 called_pattern X.\r\nconfig dialplan rule to_sip_3 callerid_pattern Var19\r\nconfig dialplan rule to_sip_3 outgoing_called {}\r\nconfig dialplan rule to_sip_3 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule to_sip_3 answer_timeout 90\r\nconfig dialplan rule to_sip_3 duration_limit 0\r\n#\r\nconfig dialplan rule to_sip_4 source_peer local from_tdm\r\nconfig dialplan rule to_sip_4 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_4 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_4 called_pattern X.\r\nconfig dialplan rule to_sip_4 callerid_pattern X.\r\nconfig dialplan rule to_sip_4 outgoing_called {}\r\nconfig dialplan rule to_sip_4 outgoing_callerid Var17\r\nconfig dialplan rule to_sip_4 answer_timeout 90\r\nconfig dialplan rule to_sip_4 duration_limit 0\r\n#\r\nconfig save\r\nconfig apply\r\n#";
            #endregion
            // ------------------------------------------- Config - Digistar - VOZ ---------------------------------------------------
            #region
            string digistar = "conf t\r\n!\r\ninterface dialer 0\r\n  shutdown\r\n!\r\ninterface dialer 1\r\n  shutdown\r\n!\r\ninterface ethernet 1\r\ndescription var01\r\nbandwidth var02k\r\nspeed 100t full\r\nno shutdown\r\n!\r\nno access-list sequence-numbers\r\nip domain lookup\r\n!\r\nno ip pmtu-discovery\r\nip ftp server\r\nip ftp banner CPE\r\nip ftp passv 6000 6003\r\n!\r\nlogging on\r\n!\r\nip http server\r\nip http secure-server\r\nip ssh server\r\nip telnet server\r\nipv6 hop-limit 64\r\nipv6 fragment time 60\r\n!\r\nip route static inter-vrf\r\nip route 0.0.0.0/0 var07\r\nipv6 route static inter-vrf\r\n!\r\nsip\r\n  user EX-USER\r\n  transport udp port 5060\r\n  codec g729\r\n  codec fax t38\r\n  no vad\r\n  dtmf outband\r\n  cid from uri\r\n  prack\r\n  no compact-headers\r\n  signalling 180-sdp\r\n  account range QuantRange\r\n  set-range user VarRange\r\nallow-simult\r\nserver 1\r\n!\r\n!\r\nRegraAccounts!\r\n!\r\n  vsp 1\r\n    only-proxy local-ip\r\n    server Var16 5060\r\n    no did display-name\r\n    no did contact\r\n    no did restricted-id\r\n    no expire-time\r\n    no proxy-server\r\n    cid from uri\r\n    dtmf outband\r\n    codec g729\r\n    codec fax t38\r\n    no vad\r\n    prack\r\n    no compact-headers\r\n    timeout 20\r\n    signalling 180-sdp\r\n    no remote-codec\r\n    no shutdown\r\n  !\r\n  no vsp 2\r\n  no vsp 3\r\n  no vsp 4\r\n  no vsp 5\r\n  rtp port-range 10000 12000 dscp ef-class\r\n  dscp ef-class\r\n!\r\nno aaa new-model\r\n!\r\nline console\r\n!\r\nline vty\r\n  password PRO1AN\r\n!\r\n!\r\nno ntp authenticate\r\nno session-timeout\r\nbanner motd ^\r\n||========================================||\r\n||=============CLARO Brasil S.A.============||\r\n||========================================||\r\n\r\n        SOMENTE USUARIOS AUTORIZADOS\r\n           AUTHORIZED USERS ONLY\r\n\r\n        OS ACESSOS SERAO MONITORADOS\r\n         ACCESSES WILL BE MONITORED\r\n\r\n||========================================||^\r\n!\r\n!\r\nservice password-encryption\r\nhostname var00\r\nno debug pbx loglevel 5\r\n!\r\n!\r\n!\r\nsinalizacao\r\n!\r\n!\r\n!\r\npbx\r\n dial-analisis dial ^(0800|0300|0303) digits 11\r\n  dial-analisis dial ^0[1-9]N1[1-9]9 digits 14\r\n  dial-analisis dial ^0[1-9]N2[1|2|4|7|8]9 digits 14\r\n  dial-analisis dial ^0[1-9]N9[1-9]9 digits 14\r\n  dial-analisis dial ^0[1-9]NNN[6-9] digits 14\r\n  dial-analisis dial ^0[1-9]NNN5 digits 20\r\n  dial-analisis dial ^0[1-9]NNNN digits 13\r\n  dial-analisis dial ^00NN digits 20\r\n  dial-analisis dial ^9090[6-9] digits 13 collect\r\n  dial-analisis dial ^90905 digits 20 collect\r\n  dial-analisis dial ^9090? digits 12 collect\r\n  dial-analisis dial ^90??1[1-9]9 digits 15 collect\r\n  dial-analisis dial ^90??2[1|2|4|7|8]9 digits 15 collect\r\n  dial-analisis dial ^90??9[1-9]9 digits 15 collect\r\n  dial-analisis dial ^90??NN[6-9] digits 15 collect\r\n  dial-analisis dial ^90??NN5 digits 20 collect\r\n  dial-analisis dial ^90??NN? digits 14 collect\r\n  dial-analisis dial ^[6-9] digits 9\r\n  dial-analisis dial ^5 digits 20\r\n  dial-analisis dial ^103?? digits 5\r\n  dial-analisis dial ^105? digits 4\r\n  dial-analisis dial ^106?? digits 5\r\n  dial-analisis dial ^1NN? digits 4\r\n  dial-analisis dial ^[2-4] digits 8\r\ngroup voip slot 0 type bidirectional \r\ngroup voip slot 0 description default \r\ngroup voip slot 0 local-tone \r\ngroup voip slot 1 type bidirectional \r\ngroup voip slot 2 type bidirectional \r\ngroup voip slot 3 type bidirectional \r\ngroup voip slot 4 type bidirectional \r\ngroup voip slot 5 type bidirectional \r\ngroup voip slot 6 type bidirectional \r\ngroup voip slot 7 type bidirectional \r\ngroup voip slot 8 type bidirectional \r\ngroup voip slot 9 type bidirectional \r\nchannels group voip 60 0 0 0 0 0 0 0 0 0 \r\ngroup e1 slot 0 type bidirectional \r\ngroup e1 slot 0 description default \r\ngroup e1 slot 1 type bidirectional \r\ngroup e1 slot 2 type bidirectional \r\ngroup e1 slot 3 type bidirectional \r\ngroup e1 slot 4 type bidirectional \r\ngroup e1 slot 5 type bidirectional \r\ngroup e1 slot 6 type bidirectional \r\ngroup e1 slot 7 type bidirectional \r\ngroup e1 slot 8 type bidirectional \r\ngroup e1 slot 9 type bidirectional\r\nchannels group e1 quantCanais 0 0 0 0 0 0 0 0 0\r\nredirection input voip-operator groups 0 from * to * output e1 groups 0 from {From} to {To:-4}\r\nredirection input voip-operator groups 0 from * to 9090Var19$ output e1 groups 0 from {From} to {To:8}\r\nredirection input voip-operator groups 0 from * to 9021Var18Var19$ output e1 groups 0 from {From} to {To:8}\r\nredirection input e1 groups 0 from ^Var19$ to * output voip-operator groups 0 from {From} to {To}\r\nredirection input e1 groups 0 from ^Var19$ to * output voip-operator groups 0 from Var17{From} to {To}\r\nredirection input  e1 groups 0 from * to * output voip-operator groups 0 from Var17 to {To}\r\n voip-gain tx percent 100 rx percent 100\r\n!\r\n!\r\n!\r\nend\r\n!";
            #endregion
            // ------------------------------------------- Config - Broadsoft - VOZ --------------------------------------------------
            // Not Implemented

            //--------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------ LOGS --------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Log - Cisco - BLD ---------------------------------------------------------
            #region
            string ciscoLogsBLD = "terminal length 0 \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "undebug all\r\n" +
                    "wr memory\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!############## CONFIGURACOES switchType DO CPE ################ \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            CONFIGURACOES            #\r\n" +
                    "!#######################################\r\n" +
                    "!\r\n" +
                    "show startup-config\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!#######################################\r\n" +
                    "!#            INTERFACES               #\r\n" +
                    "!#######################################\r\n" +
                    "show ip int brief\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "show interface var03\r\n" +
                    "!\r\n" +
                    "vlanWan" +
                    "intLan" +
                    "vlanLan" +
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
                    "ping var07 repeat 200 size 1500 isrdata 5050 sourceLan \r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n" +
                    "!\r\n";
            #endregion
            // ------------------ Parte 2 ----------------------
            #region
            string ciscoLogsParte2 = "##### Configuracoes switchType no CPE - Parte II ##### \r\n" +
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
            #endregion
            // ------------------ Limpeza BLD ------------------
            #region
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
            #endregion
            // ------------------ Limpeza MPLS -----------------
            #region
            string ciscoLogsMPLSLimpeza = "";
            #endregion
            // ------------------------------------------- Log - HPE - BLD -----------------------------------------------------------
            #region
            string hpeLogsBLD = "screen-length disable\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "############## CONFIGURAÇÕES switchType DO CPE ################ \r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "save f\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#            CONFIGURACOES             #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display saved-configuration\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "########################################\r\n" +
                    "#             INTERFACES               #\r\n" +
                    "########################################\r\n" +
                    "#\r\n" +
                    "display ip interface brief\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "display interface var03\r\n" +
                    "#\r\n" +
                    "#\r\n" +
                    "vlanWan" +
                    "intLan" +
                    "vlanLan" +
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
            #endregion
            // ------------------ Parte 2 ----------------------
            #region
            string hpeLogsParte2 = "##### Configuracoes switchType no CPE - Parte II ##### \r\n" +
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
            #endregion
            // ------------------ Limpeza BLD ------------------
            #region
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
            #endregion
            // ------------------ Limpeza MPLS -----------------
            #region
            string hpeLogsMPLSLimpeza = "";
            #endregion
            // ------------------------------------------- Log - Fortigate - BLD -----------------------------------------------------
            #region
            string fortigateLogsBLD = "############ CONFIGURACOES logType ############\r\n" +
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
                    "# CONFIGURACOES DO SYSTEMA \r\n" +
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
                    "nicLan" +
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
            #endregion
            // ------------------------------------------- Log - Huawei - BLD --------------------------------------------------------
            #region
            string huaweiLogsBLD = "screen-length 0 temporary\r\n#\r\n#\r\n#\r\n#\r\n########### CONFIGURACOES switchType ############\r\n#\r\n#\r\n#\r\ndisplay vrrp brief\r\n#\r\n#\r\ndisplay nat session all\r\n#\r\n#\r\ndisplay ospf peer\r\n#\r\ndisplay ospf interface\r\n#\r\ndisplay ospf lsdb\r\n#\r\n#\r\n#\r\ndisplay rip 1 neighbor\r\n#\r\ndisplay rip 1 database\r\n#\r\ndisplay rip 1 route\r\n#\r\n#\r\n#\r\n#\r\n#\r\nsave\r\ny\r\n#\r\n#\r\n#\r\n#\r\n########### CONFIGURACOES #############\r\n#\r\n#\r\n#\r\ndisplay saved-configuration\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### INTERFACES #############\r\n#\r\n#\r\n#\r\ndisplay ip interface brief\r\n#\r\n#\r\n#\r\ndisplay interface var03\r\n#\r\n#\r\nwithVlanwithLanlanWithVlan########### SYSTEM ##############\r\n#\r\n#\r\n#\r\ndisplay version\r\n#\r\n#\r\ndisplay sn\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### POLICES ##############\r\n#\r\n#\r\n#\r\ndisplay traffic-policy applied-record\r\n#\r\n#\r\ndisplay traffic policy statistics interface outVlan outbound\r\n#\r\n#\r\ndisplay traffic policy user-defined\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### TABELA DE ROTEAMENTO #############\r\n#\r\n#\r\n#\r\ndisplay ip routing-table protocol static\r\n#\r\n#\r\ndisplay ip routing-table\r\n#\r\n#\r\ndisplay ip routing-table statistics\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### PING #############\r\n#\r\n#\r\n#\r\nping -s 1500 -c 20 sourceLan var07\r\n#\r\n#\r\n#\r\n#\r\n#\r\n\r\n";
            #endregion
            //-------------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Cisco - MPLS --------------------------------------------------------
            #region
            string ciscoLogsMPLS = "terminal length 0 \r\n!\r\n!\r\nundebug all\r\nwr memory\r\n!\r\n!\r\n!############## CONFIGURACOES switchType DO CPE ################ \r\n!\r\n!\r\n!#######################################\r\n!#            CONFIGURACOES            #\r\n!#######################################\r\n!\r\nshow startup-config\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#            INTERFACES               #\r\n!#######################################\r\n!\r\nshow ip interface brief\r\n!\r\n!\r\n!\r\nshow interface var03\r\n!\r\n!\r\nwithVlan\r\nwithLan\r\nLanWithVlan\r\n!#######################################\r\n!#            SYSTEM INFO              #\r\n!#######################################\r\n!\r\nshow version\r\n!\r\n!\r\nshow inventory\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#              POLICY-MAP             #\r\n!#######################################\r\n!\r\nshow policy-map\r\n!\r\n!\r\n!\r\nshow policy-map interface\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#                BGP                  #\r\n!#######################################\r\n!\r\nshow ip route summary\r\n!\r\n!\r\n!#############################\r\n!\r\nshow ip bgp summary\r\n!\r\n!\r\n!#############################\r\n!\r\nshow ip bgp neighbors  var07 advertised-routes\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#                PING                 #\r\n!#######################################\r\n!\r\nping var07 repeat 200 size 1500 isrdata 5050 sourceLan\r\n!\r\n!\r\n!\r\n!\r\n\r\n";
            #endregion
            // ------------------------------------------- Log - HPE - MPLS ----------------------------------------------------------
            #region
            string hpeLogsMPLS = "screen-length disable\r\n#\r\n#\r\n############## CONFIGURAÇÕES switchType DO CPE ################ \r\n#\r\nsave f\r\n#\r\n#\r\n########################################\r\n#            CONFIGURACOES             #\r\n########################################\r\n#\r\ndisplay saved-configuration\r\n#\r\n#\r\n#\r\n########################################\r\n#             INTERFACES               #\r\n########################################\r\n#\r\ndisplay ip interface brief\r\n#\r\n#\r\n#\r\ndisplay interface var03\r\n#\r\n#\r\n#\r\nwithVlan\r\nwithLan\r\nLanWithVlan\r\n!#######################################\r\n#            SYSTEM INFO               #\r\n!#######################################\r\n#\r\ndisplay version\r\n#\r\n#\r\ndisplay device manuinfo\r\n#\r\n#\r\n#\r\n########################################\r\n#            QoS POLICY                #\r\n########################################\r\n#\r\ndisplay qos policy interface\r\n#\r\n#\r\n#\r\n#\r\n########################################\r\n#                BGP                   #\r\n########################################\r\n#\r\ndisplay bgp peer ipv4\r\n#\r\n#\r\n#\r\n#################################################\r\n#\r\ndis bgp routing-table ipv4 peer var07 ad\r\n#\r\n#\r\n#\r\n#################################################\r\n#\r\ndisplay ip routing-table protocol static\r\n#\r\n#\r\n#\r\n#################################################\r\n#\r\ndisplay ip routing-table statistics\r\n#\r\n#\r\n#\r\n#\r\n########################################\r\n#                 PING                 # \r\n########################################\r\n#\r\nping -s 1500 -c 20 sourceLanvar07\r\n#\r\n#\r\n#\r\n";
            #endregion
            // ------------------------------------------- Log - Fortigate - MPLS ----------------------------------------------------
            #region
            string fortigateLogsMPLS = "############ CONFIGURACOES logType ############\r\n" +
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
                    "# CONFIGURACOES DO SYSTEMA \r\n" +
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
                    "nicLan" +
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
            #endregion
            // ------------------------------------------- Log - Huawei - MPLS -------------------------------------------------------
            #region
            string huaweiLogsMPLS = "screen-length 0 temporary\r\n#\r\n#\r\n#\r\n#\r\n########### CONFIGURACOES switchType ############\r\n#\r\n#\r\n#\r\ndisplay vrrp brief\r\n#\r\n#\r\ndisplay nat session all\r\n#\r\n#\r\ndisplay ospf peer\r\n#\r\ndisplay ospf interface\r\n#\r\ndisplay ospf lsdb\r\n#\r\n#\r\n#\r\ndisplay rip 1 neighbor\r\n#\r\ndisplay rip 1 database\r\n#\r\ndisplay rip 1 route\r\n#\r\n#\r\n#\r\n#\r\n#\r\nsave\r\ny\r\n#\r\n#\r\n#\r\n#\r\n########### CONFIGURACOES #############\r\n#\r\n#\r\n#\r\ndisplay saved-configuration\r\n#\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### INTERFACES #############\r\n#\r\n#\r\n#\r\ndisplay ip interface brief\r\n#\r\n#\r\n#\r\ndisplay interface var03\r\n#\r\n#\r\nwithVlanwithLanlanWithVlan########### SYSTEM ##############\r\n#\r\n#\r\n#\r\ndisplay version\r\n#\r\n#\r\ndisplay sn\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### POLICES ##############\r\n#\r\n#\r\n#\r\ndisplay traffic-policy applied-record\r\n#\r\n#\r\ndisplay traffic policy statistics interface outVlan outbound\r\n#\r\n#\r\ndisplay traffic policy user-defined\r\n#\r\n#\r\n#\r\n#\r\n#\r\n############## BGP ###############\r\n#\r\n#\r\n#\r\ndisplay bgp peer\r\n#\r\n#\r\n#\r\ndis bgp routing-table peer var07 ad\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### TABELA DE ROTEAMENTO #############\r\n#\r\n#\r\n#\r\ndisplay ip routing-table protocol static\r\n#\r\n#\r\ndisplay ip routing-table\r\n#\r\n#\r\ndisplay ip routing-table statistics\r\n#\r\n#\r\n#\r\n#\r\n#\r\n########### PING #############\r\n#\r\n#\r\n#\r\nping -s 1500 -c 20 sourceLanvar07\r\n#\r\n#\r\n#\r\n#\r\n#\r\n\r\n\r\n";
            #endregion
            //-------------------------------------------------------------------------------------------------------------------------
            // ------------------------------------------- Log - Cisco - VOZ ---------------------------------------------------------
            #region
            string ciscoLogsVOZ = "terminal length 0 \r\n!\r\n!\r\nundebug all\r\nwr memory\r\n!\r\n!\r\n!############## CONFIGURACOES switchType DO CPE ################ \r\n!\r\n!\r\n!#######################################\r\n!#            CONFIGURACOES            #\r\n!#######################################\r\n!\r\nshow startup-config\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#            INTERFACES               #\r\n!#######################################\r\n!\r\nshow ip int brief\r\n!\r\n!\r\n!\r\nshow interface var03\r\n!\r\n!\r\nwithVlan\r\npabxip\r\nsinalizacao\r\n!#######################################\r\n!#            SYSTEM INFO              #\r\n!#######################################\r\n!\r\nshow version\r\n!\r\n!\r\nshow inventory\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#              POLICY-MAP             #\r\n!#######################################\r\n!\r\nshow policy-map\r\n!\r\n!\r\n!\r\nshow policy-map interface \r\n!\r\n!\r\n!\r\n!#######################################\r\n!#         TABELA DE ROTEAMENTO        #\r\n!#######################################\r\n!\r\nshow ip route summary\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#                PING                 #\r\n!#######################################\r\n!\r\nping var07 repeat 200 size 1500 isrdata 5050 sourceLan\r\n!\r\n!\r\n!\r\n!\r\n\r\n";
            #endregion
            // ------------------------------------------- Log - HPE - VOZ -----------------------------------------------------------
            #region
            string hpeLogsVOZ = "screen-length disable\r\n#\r\n#\r\n############## CONFIGURAÇÕES switchType DO CPE ################ \r\n#\r\nsave f\r\n#\r\n#\r\n########################################\r\n#            CONFIGURACOES             #\r\n########################################\r\n#\r\ndisplay saved-configuration\r\n#\r\n#\r\n#\r\n########################################\r\n#             INTERFACES               #\r\n########################################\r\n#\r\ndisplay ip interface brief\r\n#\r\n#\r\n#\r\ndisplay interface var03\r\n#\r\n#\r\nwithVlan\r\npabxip\r\nsinalizacao\r\n########################################\r\n#            SYSTEM INFO               #\r\n########################################\r\n#\r\ndisplay version\r\n#\r\n#\r\ndisplay device manuinfo\r\n#\r\n#\r\n#\r\n########################################\r\n#            QoS POLICY                #\r\n########################################\r\n#\r\ndisplay qos policy interface\r\n#\r\n#\r\n#\r\n#\r\n########################################\r\n#         TABELA DE ROTEAMENTO         #\r\n########################################\r\n#\r\ndisplay ip routing-table\r\n#\r\n#\r\n#\r\n########################################\r\n#                 PING                 # \r\n########################################\r\n#\r\nping -s 1500 -c 20 sourceLanvar07\r\n#\r\n#\r\n#\r\n#\r\n\r\n";
            #endregion
            // ------------------------------------------- Log - Aligera - VOZ -------------------------------------------------------
            #region
            string aligeraLogs = "!######### CONFIGURACOES switchType DO CPE ######### \r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!\r\n!#######################################\r\n!# SYSTEM INFO \r\n!#######################################\r\n!\r\nstatus network\r\n!\r\n!\r\nsystem info\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# PING \r\n!#######################################\r\n!\r\ntools ping -c 20 -s 1500 var07\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# STATUS E1 \r\n!#######################################\r\n!\r\nstatus tdm\r\n!\r\n!\r\n!\r\n!#######################################\r\n!# CONFIGURACOES \r\n!#######################################\r\n!\r\nconfig show\r\n!\r\n!\r\n!\r\n";
            #endregion
            // ------------------------------------------- Log - Digistar - VOZ ------------------------------------------------------
            #region
            string digistarLogs = "!\r\nwr\r\nterminal length 0\r\n!\r\n!\r\n!####### CONFIGURACOES switchType DO CPE ################\r\n!\r\n!#######################################\r\n!#            CONFIGURACOES            #\r\n!#######################################\r\n!\r\nshow startup-config\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#              INTERFACE              #\r\n!#######################################\r\n!\r\nshow ip interface brief\r\n!\r\n!\r\n!\r\nshow interface ethernet 1\r\n!\r\n!\r\nwithVlan\r\n!#######################################\r\n!#             STATUS E1               #\r\n!#######################################\r\n!\r\nshow pbx group status tdm\r\n!\r\n!\r\nshow pbx digital-line 1 status\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#            SYSTEM INFO              #\r\n!#######################################\r\n!\r\nshow tech\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#         TABELA DE ROTEAMENTO        #\r\n!#######################################\r\n!\r\nshow ip route\r\n!\r\n!\r\n!\r\n!#######################################\r\n!#                PING                 #\r\n!#######################################\r\n!\r\nping var07 rep 20 size 1472\r\n!\r\n!\r\n!\r\n\r\n";
            #endregion
            // ------------------------------------------- Log - Broadsoft - VOZ -----------------------------------------------------
            // Not Implemented

            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- WizardGat ------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- WizGat - Cisco - BLD ------------------------------------------------------
            #region
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
            #endregion
            // ------------------------------------------- WizGat - Cisco - MPLS -----------------------------------------------------
            #region
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
                "show running-config vrf var14xf\r\n" +
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
                "xv" +
                "show ip bgpxr vrf var14\r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgpxr vrf var14 sum | inc var08\r\n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgpxr vrf var14 neighbor var08 advertised-routes | i xes \n" +
                " \r\n" +
                " \r\n" +
                "!################################## \r\n" +
                " \r\n" +
                "show ip bgpxr vrf var14 neighbor var08 routes\r\n" +
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
            #endregion
            // ------------------------------------------- WizGat - Cisco - VOZ ------------------------------------------------------
            #region
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
                "show policy-map interface var03\r\n" +
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
            #endregion
            // ------------------------------------------- WizGat - Cisco - BLD com BGP ----------------------------------------------
            #region
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
            "var08\r\n" +
            "15\r\n" +
            "1500\r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n" +
            " \r\n";
            #endregion
            // ------------------------------------------- WizGat - Nokia - BLD ------------------------------------------------------
            #region
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
            #endregion
            // ------------------------------------------- WizGat - Nokia - MPLS -----------------------------------------------------
            #region
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
                "show router service-name var15 interface var03 \r\n" +
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
            #endregion
            // ------------------------------------------- WizGat - Nokia - VOZ ------------------------------------------------------
            #region
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
            #endregion
            // ------------------------------------------- WizGat - Nokia - BLD com BGP ----------------------------------------------
            #region
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
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- Outros ---------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            // -------------------------------------------------- SNMP ----------------------------------------------------------------
            #region
            string snmpv2Cisco = "conf t\r\n!\r\n!\r\nsnmp-server community VarCom VarTipo\r\n!\r\n!\r\nend\r\n";

            string snmpv2CiscoHost = "con t \r\n!\r\n!\r\nsnmp-server community VarCom VarTipo\r\nsnmp-server host VarHost VarCom\r\n!\r\n!\r\nend\r\n";

            string snmpv2HPE = "sys\r\n" +
                "#\r\n" +
                "snmp-agent\r\n" +
                "snmp-agent local-engineid\r\n" +
                "snmp-agent community VarTipo VarCom\r\n" +
                "snmp-agent sys-info version all\r\n" +
                "#\r\n" +
                "#\r\n" +
                "return\r\n";

            string snmpv2HPEcomHost = "sys\r\n" +
                "#\r\n" +
                "snmp-agent\r\n" +
                "snmp-agent local-engineid\r\n" +
                "snmp-agent community VarTipo VarCom\r\n" +
                "snmp-agent sys-info version all\r\n" +
                "snmp-agent target-host trap address udp-domain VarHost params securityname VarCom\r\n" +
                "#\r\n" +
                "#\r\n" +
                "return\r\n";

            string snmpv2Huawei = "sys\r\n" +
                "#\r\n" +
                "snmp-agent target-host trap-paramsname SNMPV1 v1 securityname VarCom\r\n" +
                "snmp-agent target-host trap-paramsname SNMPV2 v2c securityname VarCom\r\n" +
                "#\r\n" +
                "#\r\n" +
                "return\r\n";

            string snmpv2HuaweicomHost = "sys\r\n" +
                "#\r\n" +
                "snmp-agent target-host trap-paramsname SNMPV1 v1 securityname VarCom\r\n" +
                "snmp-agent target-host trap-paramsname SNMPV2 v2c securityname VarCom\r\n" +
                "snmp-agent target-host trap-hostname host1 address VarHost trap-paramsnam SNMPV1\r\n" +
                "snmp-agent target-host trap-hostname host2 address VarHost trap-paramsnam SNMPV2\r\n" +
                "#\r\n" +
                "#\r\n" +
                "return\r\n";

            string snmpv2Fortgate = "config system snmp community\r\n" +
                "edit 0\r\n" +
                "set name " + '"' + "VarCom" + '"' + "\r\n" +
                "end\r\n" +
                "\r\n" +
                "\r\n" +
                "config system snmp sysinfo\r\n" +
                "set status enable\r\n" +
                "end\r\n";

            string snmpv2FortgatecomHost = "config system snmp community\r\n" +
                "edit 0\r\n" +
                "set name " + '"' + "VarCom" + '"' + "\r\n" +
                "config hosts\r\n" +
                "edit 0\r\n" +
                "set ip VarHost 255.255.255.255\r\n" +
                "end\r\n" +
                "next\r\n" +
                "end\r\n" +
                "\r\n" +
                "\r\n" +
                "config system snmp sysinfo\r\n" +
                "set status enable\r\n" +
                "end\r\n" +
                "\r\n" +
                "\r\n" +
                "###############################################################\r\n# Utilizar apenas se o router já possuir Trusthosts configurados. \r\n# Caso contrario, configuracao abaixo näo é necessaria\r\n###############################################################\r\n#\r\n#\r\n\r\n" +
                "\r\n" +
                "config system admin\r\n" +
                "edit " + '"' + "EBT" + '"' + "\r\n" +
                "set trusthost4 VarHost 255.255.255.255\r\n" +
                "next\r\n" +
                "end\r\n"; ;

            #endregion

            // --------------------------------------------------- QoS ----------------------------------------------------------------
            #region
            string qosCisco = "conf t\r\n!\r\nip cef\r\n!\r\n!\r\n!\r\nVarEnVoz\r\nVarEnVideo\r\nVarEnMissao\r\nVarEnInterativa\r\nVarEnBulk\r\nVarEnNetwork\r\n!\r\n!\r\nVarEnDscpVoz\r\nVarEnDscpVideo\r\nVarEnDscpMissao\r\nVarEnDscpInterativa\r\nVarEnDscpBulk\r\nVarEnDscpNetwork\r\nVarEnDscpBest\r\n!\r\n!\r\nVarSaiVoz\r\nVarSaiVideo\r\nVarSaiMissao\r\nVarSaiInterativa\r\nVarSaiBulk\r\nVarSaiNetwork\r\n!\r\n!\r\npolicy-map SaidaWAN\r\n!\r\nVarSaiDscpVoz\r\nVarSaiDscpVideo\r\nVarSaiDscpMissao\r\nVarSaiDscpInterativa\r\nVarSaiDscpBulk\r\nVarSaiDscpNetwork\r\nVarSaiDscpBest\r\n!\r\n!\r\ninterface VarWan\r\n service-policy output SaidaWAN\r\n!\r\ninterface VarLan\r\n service-policy input EntradaLanCE\r\n!\r\n!\r\n!\r\n";
            string qosHPE = "sys\r\n#\r\n#\r\nVarEnMarcaVoz\r\nVarEnMarcaVideo\r\nVarEnMarcaMissao\r\nVarEnMarcaInterativa\r\nVarEnMarcaBulk\r\nVarEnMarcaNetwork\r\n#\r\n#\r\nVarEnVoz\r\nVarEnVideo\r\nVarEnMissao\r\nVarEnInterativa\r\nVarEnBulk\r\nVarEnNetwork\r\n#\r\n#\r\nqos policy EntradaLanCE\r\nVarEnDscpVoz\r\nVarEnDscpVideo\r\nVarEnDscpMissao\r\nVarEnDscpInterativa\r\nVarEnDscpBulk\r\nVarEnDscpNetwork\r\n#\r\n#\r\n#\r\nVarSaiMarcaVoz\r\nVarSaiMarcaVideo\r\nVarSaiMarcaMissao\r\nVarSaiMarcaInterativa\r\nVarSaiMarcaBulk\r\nVarSaiMarcaNetwork\r\nVarSaiMarcaBest\r\n#\r\n#\r\n#\r\nVarSaiVoz\r\nVarSaiVideo\r\nVarSaiMissao\r\nVarSaiInterativa\r\nVarSaiBulk\r\nVarSaiNetwork\r\nVarSaiBest\r\n#\r\n#\r\n#\r\nqos policy SaidaWAN\r\nVarSaiDscpVoz\r\nVarSaiDscpVideo\r\nVarSaiDscpMissao\r\nVarSaiDscpInterativa\r\nVarSaiDscpBulk\r\nVarSaiDscpNetwork\r\nVarSaiDscpBest\r\n#\r\n#\r\n#\r\ninterface VarWan\r\nQOS apply policy SaidaWAN outbound\r\n#\r\ninterface VarLan\r\nQOS apply policy EntradaLanCE inbound\r\nend\r\n";
            string qosHuawei = "sys\r\n#\r\n#\r\nVarEnVoz\r\nVarEnVideo\r\nVarEnMissao\r\nVarEnInterativa\r\nVarEnBulk\r\nVarEnNetwork\r\nVarEnpBest\r\n#\r\n#\r\n#\r\nVarEnDscpVoz\r\nVarEnDscpVideo\r\nVarEnDscpMissao\r\nVarEnDscpInterativa\r\nVarEnDscpBulk\r\nVarEnDscpNetwork\r\nVarEnDscpBest\r\n#\r\n#\r\n#\r\ntraffic policy QoS\r\nVarSaiVoz\r\nVarSaiVideo\r\nVarSaiMissao\r\nVarSaiInterativa\r\nVarSaiBulk\r\nVarSaiNetwork\r\nVarSaiDscpBest\r\n#\r\n#\r\ninterface VarWan\r\ntraffic-policy QoS outbound\r\n#\r\n#\r\n#\r\nreturn\r\n#\r\n";
            string qosFortigate = "config firewall traffic-class\r\nVarEnVoz\r\nVarEnVideo\r\nVarEnMissao\r\nVarEnNetwork\r\nVarEnInterativa\r\nVarEnBulk\r\nVarEnBest\r\nend\r\n#\r\n#\r\n#\r\nconfig firewall shaping-policy\r\nVarEnDscpVoz\r\nVarEnDscpVideo\r\nVarEnDscpMissao\r\nVarEnDscpNetwork\r\nVarEnDscpInterativa\r\nVarEnDscpBulk\r\nVarEnDscpBest\r\nend\r\n#\r\n#\r\n#\r\nconfig firewall shaping-profile\r\n    edit \"WAN_OUT\"\r\n        set type queuing\r\n        set default-class-id 16\r\n        config shaping-entries\r\nVarSaiVoz\r\nVarSaiVideo\r\nVarSaiMissao\r\nVarSaiNetwork\r\nVarSaiInterativa\r\nVarSaiBulk\r\nVarSaiDscpBest\r\n        end\r\n    next\r\nend\r\n#\r\n#\r\n#\r\nconfig system interface\r\n    edit \"VarWan\"\r\n        set outbandwidth VarBanda \r\n        set egress-shaping-profile \"WAN_OUT\"\r\nend\r\n#\r\n#\r\n";
            #endregion

            // --------------------------------------------------- BGP ----------------------------------------------------------------
            #region
            string bgpCisco = "router bgp VarAS\r\nno synchronization \r\nbgp log-neighbor-changes \r\nredistribute connected \r\nneighbor VarIP remote-as 4230\r\nneighbor VarIP send-community\r\nneighbor VarIP allowas-in\r\nneighbor VarIP description designacao\r\nneighbor VarIP soft-reconfiguration inbound\r\nno auto-summary\r\nVarRemote";
            string bgpHPE = "bgp VarAS\r\npeer VarIP as-number 4230\r\npeer VarIP description designacao\r\nVarRemote\r\n#\r\naddress-family ipv4 unicast\r\nimport-route direct\r\npeer VarIP enable\r\npeer VarIP allow-as-loop 10\r\npeer VarIP advertise-community\r\n#";
            string bgpHuawei = "bgp VarAS\r\n router-id VarCPE\r\n peer VarIP as-number 4230\r\n peer VarIP description designacao\r\n VarRemote\r\n #\r\n ipv4-family unicast\r\n  undo synchronization\r\n  import-route direct\r\n  import-route static\r\n  peer VarIP enable\r\n  peer VarIP allow-as-loop 10\r\n#\r\n#\r\n";
            string bgpFortigate = "config router bgp\r\nset as VarAS\r\nset log-neighbour-changes enable\r\nset router-id VarCPE\r\nconfig neighbor\r\nedit \"VarIP\"\r\nset allowas-in-enable enable\r\nset description \"designacao\"\r\nset soft-reconfiguration enable\r\nset remote-as 4230\r\nnext\r\nVarRemote\r\nend\r\n#\r\nconfig redistribute \"connected\"\r\nset status enable\r\nend\r\nend\r\n#\r\n#\r\n";
            #endregion

            // ------------------------------------------   Regras Adicionais ---------------------------------------------------------
            #region
            string regraVozCisco = "conf t\r\n!\r\n!\r\nvoice translation-rule 10\r\nno rule NumRegraSaida0\r\nno rule NumRegraSaida1\r\nno rule NumRegraSaida2\r\nrule NumRegraSaida0 /^\\(VarNovaRegra\\)/ /\\1/\r\nrule NumRegraSaida1 /^\\(regraMCDU\\)/ /regra4Digitos\\1/\r\nrule NumRegraSaida2 /^.*/ /Var17/\r\n!\r\n!\r\n!\r\ndial-peer voice NumRegra0 pots\r\n description INBOUND - LOCAL\r\ndestination-pattern VarNovaRegra\r\n progress_ind alert strip 8\r\n direct-inward-dial\r\n forward-digits 4\r\n port portVoice\r\n!\r\n!\r\n!\r\nend\r\nwr\r\n!";
            string regraVozCiscoISR = "conf t\r\n!\r\n!\r\nvoice translation-rule 10\r\nno rule NumRegraSaida0\r\nno rule NumRegraSaida1\r\nno rule NumRegraSaida2\r\nrule NumRegraSaida0 /^\\(VarNovaRegra\\)/ /\\1/\r\nrule NumRegraSaida1 /^\\(regraMCDU\\)/ /regra4Digitos\\1/\r\nrule NumRegraSaida2 /^.*/ /Var17/\r\n!\r\n!\r\n!\r\ndial-peer voice NumRegra0 pots\r\n port portVoice\r\n description INBOUND  Rede Publica para tronco Vipline\r\ndestination-pattern VarNovaRegra$\r\n direct-inward-dial\r\n forward-digits 4\r\n!\r\ndial-peer voice NumRegra1 pots\r\n port portVoice\r\n description PABX - Chamada a cobrar\r\ndestination-pattern 9090VarNovaRegra$\r\n direct-inward-dial\r\n forward-digits 4\r\n!\r\n!\r\n!\r\nend\r\nwr\r\n!";
            string regraVozHPE = "sys\r\n#\r\n#\r\nvoice-setup\r\ndial-programa\r\n#\r\nnumber-substitute 100\r\ndot-match left-right\r\nno rule NumRegraSaida0\r\nundo rule NumRegraSaida1\r\nundo rule NumRegraSaida2\r\nundo rule NumRegraSaida3\r\nrule NumRegraSaida0 ^SaidaRegra$ SaidaRegra\r\nrule NumRegraSaida1 ^SaidaMCDU$ SaidaRegra\r\nrule NumRegraSaida2 ^....$ Var17\r\nrule NumRegraSaida3 ^........$ Var17\r\n#\r\n#\r\n#\r\nentity NumRegra0 pots\r\nline portVoice\r\nsend-number 4\r\ndescription Ramais PABX\r\nmatch-template Var19\r\nvoice-class codec 1\r\noutband nte\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity NumRegra1 pots\r\nline portVoice\r\nsend-number 4\r\ndescription PABX - Chamada a cobrar\r\nmatch-template 9090VarNovaRegra\r\nvoice-class codec 1\r\noutband nte\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\nentity NumRegra2 pots\r\nline portVoice\r\nsend-number 4\r\ndescription PABX - Chamada a cobrar Longa Distancia\r\nmatch-template 9021Var18VarNovaRegra\r\nvoice-class codec 1\r\noutband nte\r\nfax protocol standard-t38 ls-redundancy 0 hs-redundancy 1\r\nmodem passthrough protocol codec g711alaw\r\n#\r\n#\r\nreturn\r\nsave f\r\n#\r\n";
            string regraVozAligera561 = "!###################################################################\r\n!REGRAS PARA CHAMADAS DE ENTRADA\r\n!###################################################################\r\n!\r\nconfig dialplan rule from_sip_local_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_local_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_local_NumRegra0 called_pattern VarNovaRegra\r\nconfig dialplan rule from_sip_local_NumRegra0 outgoing_called {:-4}\r\n!\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 called_pattern 9090VarNovaRegra\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 outgoing_called {:-4}\r\n!\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 called_pattern 9021Var18VarNovaRegra\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 outgoing_called {:-4}\r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!###################################################################\r\nREGRAS PARA CHAMADAS DE SAINTES\r\n!###################################################################\r\n!\r\nconfig dialplan rule from_tdm_local_8d_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_NumRegra1  destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_NumRegra1  called_pattern [2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_NumRegra2 called_pattern [2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_NumRegra3 called_pattern [2-8]XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra1 called_pattern 9090[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra2 called_pattern 9090[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra3 called_pattern 9090[2-8]XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra1 called_pattern 9XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra2 called_pattern 9XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra3 called_pattern 9XXXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra1 called_pattern 90909XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra2 called_pattern 90909XXXXXXXX\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra3 called_pattern 90909XXXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra1 called_pattern 0ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra2 called_pattern 0ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra3 called_pattern 0ZXZZ[2-8]XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra1 called_pattern 0ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra2 called_pattern 0ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra3 called_pattern 0ZXZZ9XXXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 called_pattern 90ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 called_pattern 90ZXZZ[2-8]XXXXXXX\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 called_pattern 90ZXZZ[2-8]XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra1 called_pattern 90ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra2 called_pattern 90ZXZZ9XXXXXXXX\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra3 called_pattern 90ZXZZ9XXXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_internacional_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_internacional_NumRegra1 called_pattern 00X.\r\nconfig dialplan rule from_tdm_internacional_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_internacional_NumRegra2 called_pattern 00X.\r\nconfig dialplan rule from_tdm_internacional_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_internacional_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_internacional_NumRegra3 called_pattern 00X.\r\n!\r\nconfig dialplan rule from_tdm_0800_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0800_NumRegra1 called_pattern 0800X.\r\nconfig dialplan rule from_tdm_0800_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0800_NumRegra2 called_pattern 0800X.\r\nconfig dialplan rule from_tdm_0800_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0800_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0800_NumRegra3 called_pattern 0800X.\r\n!\r\nconfig dialplan rule from_tdm_0300_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0300_NumRegra1 called_pattern 0300XXXXXXX\r\nconfig dialplan rule from_tdm_0300_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0300_NumRegra2 called_pattern 0300XXXXXXX\r\nconfig dialplan rule from_tdm_0300_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0300_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0300_NumRegra3 called_pattern 0300XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_0500_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0500_NumRegra1 called_pattern 0500XXXXXXX\r\nconfig dialplan rule from_tdm_0500_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0500_NumRegra2 called_pattern 0500XXXXXXX\r\nconfig dialplan rule from_tdm_0500_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0500_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0500_NumRegra3 called_pattern 0500XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_0900_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0900_NumRegra1 called_pattern 0900XXXXXXX\r\nconfig dialplan rule from_tdm_0900_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0900_NumRegra2 called_pattern 0900XXXXXXX\r\nconfig dialplan rule from_tdm_0900_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_0900_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_0900_NumRegra3 called_pattern 0900XXXXXXX\r\n!\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra1 called_pattern 19X\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra2 called_pattern 19X\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra3 called_pattern 19X\r\n!\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra1 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra1 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra1 called_pattern 1[0-8].\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra2 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra2 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra2 called_pattern 1[0-8].\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra3 source_peer tdm group1\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra3 destination_peer sip trunk1\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra3 called_pattern 1[0-8].\r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n!############################\r\n!REGRAS PARA MANIPULAÇAO DO NUMERO DE A\r\n!############################ \r\n\r\nconfig dialplan rule from_tdm_local_8d_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_local_8d_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_local_8d_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_local_8d_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_local_8d_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_local_8d_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_local_8d_cobrar_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_celular_local_9d_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_celular_local_9d_cobrar_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_8d_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_9d_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_8d_cobrar_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_ldn_9d_cobrar_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_internacional_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_internacional_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_internacional_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_internacional_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_internacional_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_internacional_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_0800_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0800_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0800_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_0800_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0800_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_0800_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_0300_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0300_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0300_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_0300_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0300_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_0300_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_0500_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0500_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0500_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_0500_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0500_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_0500_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_0900_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_0900_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_0900_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_0900_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_0900_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_0900_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_serv_pub_emerg_NumRegra3 outgoing_callerid Var17\r\n\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra1 callerid_pattern regraMCDU\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra1 outgoing_callerid regra4Digitos{}\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra2 callerid_pattern VarNovaRegra\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra2 outgoing_callerid regra4Digitos{:-4}\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra3 callerid_pattern\r\nconfig dialplan rule from_tdm_serv_pub_NumRegra3 outgoing_callerid Var17\r\n!\r\nconfig apply\r\nconfig save\r\n!\r\n";
            string regraVozAligera1600 = "!##########################################################\r\n!REGRAS PARA CHAMADAS DE ENTRADA\r\n!##########################################################\r\n!\r\nconfig dialplan rule from_sip_local_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_local_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_local_NumRegra0 called_pattern Var19\r\nconfig dialplan rule from_sip_local_NumRegra0 outgoing_called {:-4}\r\n!\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 called_pattern 9090Var19\r\nconfig dialplan rule from_sip_a_cobrar_NumRegra0 outgoing_called {:-4} \r\n!\r\nconfig dialplan rule from_sip_ldn_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_ldn_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_ldn_NumRegra0 called_pattern 021Var18Var19\r\nconfig dialplan rule from_sip_ldn_NumRegra0 outgoing_called {:-4}\r\n!\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 source_peer sip trunk1\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 destination_peer tdm group1\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 called_pattern 9021Var18Var19\r\nconfig dialplan rule from_sip_a_cobrar_ldn_NumRegra0 outgoing_called {:-4}\r\n!\r\nconfig save\r\nconfig apply\r\n!\r\n!##########################################################\r\n!Manipulaçoes do número de A enviado pelo PABX:\r\n!##########################################################\r\n!\r\nconfig dialplan rule to_sip_NumRegra1 source_peer local from_tdm\r\nconfig dialplan rule to_sip_NumRegra1 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_NumRegra1 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_NumRegra1 called_pattern X.\r\nconfig dialplan rule to_sip_NumRegra1 callerid_pattern\r\nconfig dialplan rule to_sip_NumRegra1 outgoing_called {}\r\nconfig dialplan rule to_sip_NumRegra1 outgoing_callerid Var17\r\nconfig dialplan rule to_sip_NumRegra1 answer_timeout 90\r\nconfig dialplan rule to_sip_NumRegra1 duration_limit 0\r\n!\r\nconfig dialplan rule to_sip_NumRegra2 source_peer local from_tdm\r\nconfig dialplan rule to_sip_NumRegra2 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_NumRegra2 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_NumRegra2 called_pattern X.\r\nconfig dialplan rule to_sip_NumRegra2 callerid_pattern regraMCDU\r\nconfig dialplan rule to_sip_NumRegra2 outgoing_called {}\r\nconfig dialplan rule to_sip_NumRegra2 outgoing_callerid 3218{}\r\nconfig dialplan rule to_sip_NumRegra2 answer_timeout 90\r\nconfig dialplan rule to_sip_NumRegra2 duration_limit 0\r\n!\r\nconfig dialplan rule to_sip_NumRegra3 source_peer local from_tdm\r\nconfig dialplan rule to_sip_NumRegra3 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_NumRegra3 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_NumRegra3 called_pattern X.\r\nconfig dialplan rule to_sip_NumRegra3 callerid_pattern Var19\r\nconfig dialplan rule to_sip_NumRegra3 outgoing_called {}\r\nconfig dialplan rule to_sip_NumRegra3 outgoing_callerid Var1{:-4}\r\nconfig dialplan rule to_sip_NumRegra3 answer_timeout 90\r\nconfig dialplan rule to_sip_NumRegra3 duration_limit 0\r\n!\r\nconfig dialplan rule to_sip_NumRegra4 source_peer local from_tdm\r\nconfig dialplan rule to_sip_NumRegra4 destination_peers 1 peer sip trunk1\r\nconfig dialplan rule to_sip_NumRegra4 destination_peers 1 weight 1\r\nconfig dialplan rule to_sip_NumRegra4 called_pattern X.\r\nconfig dialplan rule to_sip_NumRegra4 callerid_pattern X.\r\nconfig dialplan rule to_sip_NumRegra4 outgoing_called {}\r\nconfig dialplan rule to_sip_NumRegra4 outgoing_callerid Var17\r\nconfig dialplan rule to_sip_NumRegra4 answer_timeout 90\r\nconfig dialplan rule to_sip_NumRegra4 duration_limit 0\r\n!\r\nconfig save\r\nconfig apply\r\n!";
            string regraVozDigistar = "conf t\r\n!\r\n!\r\nRegraAccounts!\r\n!\r\n  pbx\r\n    channels group e1 30 0 0 0 0 0 0 0 0 0\r\n      redirection input voip-operator groups 0 from * to * output e1 groups 0 fr om {From} to {To:-4}\r\n\r\n      redirection input voip-operator groups 0 from * to 9090VarNovaRegra$ output e1 groups 0 from {From} to {To:8}\r\n      redirection input voip-operator groups 0 from * to 9021Var18VarNovaRegra$ output e1 groups 0 from {From} to {To:8}\r\n      redirection input e1 groups 0 from ^VarNovaRegra$ to * output voip-operator groups 0 from {From} to {To}\r\n      redirection input e1 groups 0 from ^regraMCDU$ to * output voip-operator groups 0 from regra4Digitos{From} to {To}\r\n\r\n      redirection input e1 groups 0 from * to * output voip-operator groups 0 from Var17 to {To}\r\n    !\r\n  !\r\n!\r\nend\r\n!";
            #endregion

            // -------------------------------------------------- Vlan ----------------------------------------------------------------
            #region
            string vlanCisco = "conf t\r\n!\r\ninterface Vlan21\r\ndescription ** LAN **\r\nip address VarIP mascaraIP\r\n!\r\ninterface VarInterface\r\ndescription ** LAN **\r\nswitchport access vlan 21\r\nno ip address\r\n!\r\n!\r\nend";
            string vlanCiscoCatalyst = "conf t\r\n!\r\ninterface BDI1\r\n description *** LAN ***\r\n ip address VarIP mascaraIP\r\n no cdp enable\r\n!\r\n!\r\ninterface VarInterface\r\n no ip address\r\n negotiation auto\r\n service instance 10 ethernet\r\n  encapsulation untagged\r\n  bridge-domain 1\r\n!\r\n!\r\nend\r\n";
            string vlanHPE = "sys\r\n#\r\n#\r\ninterface VarInterface\r\n port link-mode bridge\r\n description ** LAN 1 ****\r\n no shut\r\n#\r\n#\r\n#\r\nvlan 21\r\nport VarInterface\r\n#\r\n#\r\n#\r\ninterface vlan 21\r\ndescription ** LAN **\r\nip address VarIP mascaraLAN\r\n#\r\n#\r\nend";
            string vlanHuawei = "sys\r\n#\r\ninterface Vlanif21\r\ndescription ** LAN **\r\nip address VarIP mascaraIP\r\n#\r\n#\r\ninterface VarInterface\r\n description ** LAN **\r\n port link-type access\r\n port default vlan 21\r\n no shut\r\n#\r\n#\r\nreturn";
            string vlanFortigate = "";
            #endregion

            // -------------------------------------------------- DHCP ----------------------------------------------------------------
            #region
            string dhcpCisco = "conf t\t\r\n!\r\nip dhcp pool DHCP\t\r\n network VarIPNet mascaraLAN\t\r\n default-router VarIPGateway\t\r\n dns-server VarDNS1 VarDNS2\t\r\n domain-name VarDominio\r\n!\r\n!\r\nVarExclude\r\n!\r\n!\r\n!\r\nend\r\n\r\n\r\nVarRelay";
            string dhcpHPE = "sys\r\n#\r\ndhcp enable\r\ndhcp server ip-pool DHCP\r\nnetwork VarIPNet mask mascaraLAN\r\ngateway-list VarIPGateway\r\ndns-list VarDNS1 VarDNS2\r\n#\r\n#\r\nVarExclude\r\n#\r\n#\r\nreturn\r\n\r\n\r\nVarRelay";
            string dhcpHuawei = "";
            string dhcpFortigate = "config system dhcp server\r\nedit 0\r\nset dns-service specify\r\nset dns-server1 VarDNS1\r\nset dns-server2 VarDNS2\r\nset default-gateway VarIPGateway\r\nset netmask mascaraLAN\r\nset interface \"VarInterface\"\r\nconfig ip-range\r\nedit 1\r\nset start-ip VarPrimeiro\r\nset end-ip VarUltimo\r\nnext\r\nend\r\nnext\r\nend\r\n\r\n\r\nVarRelay";
            #endregion

            // -------------------------------------------------- User ----------------------------------------------------------------
            #region
            string userCisco = "conf t\t\r\n!\r\nusername VarName privilege VarPriv password 0 VarPassword\t\r\n!\r\n!\r\n!## (C1900 não precisa desse comando) ##\t\r\nfile privilege VarPriv\t\r\n!\t\r\n!\t\r\nprivilege exec level VarPriv traceroute\t\r\nprivilege exec level VarPriv ping\t\r\nprivilege exec level VarPriv show tech-support\t\r\nprivilege exec level VarPriv show policy-map interface\t\r\nprivilege exec level VarPriv show policy-map\t\r\nprivilege exec level VarPriv show bgp\t\r\nprivilege exec level VarPriv show protocols\t\r\nprivilege exec level VarPriv show ip bgp\t\r\nprivilege exec level VarPriv show ip route\t\r\nprivilege exec level VarPriv show ip interface brief\t\r\nprivilege exec level VarPriv show ip interface\t\r\nprivilege exec level VarPriv show ip\t\r\nprivilege exec level VarPriv show standby\t\r\nprivilege exec level VarPriv show diag\t\r\nprivilege exec level VarPriv show version\t\r\nprivilege exec level VarPriv show startup-config\t\r\nprivilege exec level VarPriv show running-config\t\r\nprivilege exec level VarPriv show configuration\t\r\nprivilege exec level VarPriv show interfaces\t\r\nprivilege exec level VarPriv show\t\r\nprivilege exec level VarPriv traceroute\t\r\nprivilege exec level VarPriv ping\t\r\nprivilege exec level VarPriv show\t\r\nprivilege exec level VarPriv clear counters\t\r\nprivilege exec level VarPriv clear\t\r\nprivilege exec level VarPriv show conf\t\r\n!\r\n!\r\nend";
            string userHPE = "sys\r\n#\r\nlocal-user VarName class manage\t\r\npassword simple VarPassword\t\r\nservice-type telnet terminal\t\r\nVarPriv\r\n#\r\n#\r\nend";
            string userHuawei = "sys\r\n#\r\nlocal-user EBT password irreversible-cipher PRO1AN@1\r\nlocal-user EBT password-force-change disable\r\nlocal-user EBT privilege level VarPriv\r\nlocal-user EBT service-type telnet terminal ssh\r\n#\r\n#\r\nquit";
            string userFortigate = "config system admin\r\n    edit \"EBT\"\r\n       set vdom \"root\"\r\n       set password PRO1AN\r\n       VarPriv\r\n    next\r\n#";
            #endregion

            // ------------------------------------------------- IP FLOW --------------------------------------------------------------
            #region
            string ipFlowCisco = "CISCO\t\t\r\n\r\nconf t\r\n!\r\nip flow-export source VarInterface\r\nip flow-export version 5\r\nip flow-export destination VarIPDestino VarUDP\r\n!\r\nip flow-cache timeout active 1\r\nip flow-export version 5\r\n!\r\n!\r\ninterface VarInterface\r\nip flow ingress\r\n!\r\n!\r\nend\r\n\r\n\r\nCISCO ISR\t\t\r\n\r\nconf t\r\n!\r\nflow exporter CPE \t\r\ndestination VarIPDestino\t\r\nsource VarInterface\t\r\nexport-protocol netflow-v9\t\r\ntransport udp VarUDP\t\r\n!\t\r\nflow monitor CPE \t\r\n exporter CPE \t\r\n cache timeout active 60 \t\r\n record netflow-original\r\n!\t\r\n!\r\n!\t\r\ninterface VarInterface\t\r\n ip flow monitor CPE input \t\r\n ip flow monitor CPE output \r\n!\r\n!\r\nend\r\n\r\n\r\nHP\r\n\r\nsys\r\n#\t\r\nip netstream aggregation protocol-port\r\nip netstream timeout active 5\t\r\nip netstream timeout inactive 10\t\r\nip netstream export host VarIPDestino VarUDP\r\n#\t\r\n#\t\t\r\ninterface VarInterface\t\t\r\nip netstream inbound \t\t\r\nip netstream outbound\r\n#\r\n#\r\nreturn\r\n\r\n\r\nFORTINET\r\n\t\r\nconfig system netflow\r\nset collector-ip VarIPDestino\r\nset collector-port VarUDP\r\nend\r\n#\r\n#\r\nconfig system interface\t\r\nedit \"VarInterface\"\t\r\nset netflow-sampler both\r\nend\t\r\n#\t";
            string ipFlowCiscoISR = "conf t\r\n!\r\nflow exporter CPE \t\r\ndestination VarIPDestino\t\r\nsource VarInterface\t\r\nexport-protocol netflow-v9\t\r\ntransport udp VarUDP\t\r\n!\t\r\nflow monitor CPE \t\r\n exporter CPE \t\r\n cache timeout active 60 \t\r\n record netflow-original\r\n!\t\r\n!\r\n!\t\r\ninterface VarInterface\t\r\n ip flow monitor CPE input \t\r\n ip flow monitor CPE output \r\n!\r\n!\r\nend";
            string ipFlowHPE = "sys\r\n#\t\r\nip netstream aggregation protocol-port\r\nip netstream timeout active 5\t\r\nip netstream timeout inactive 10\t\r\nip netstream export host VarIPDestino VarUDP\r\n#\t\r\n#\t\t\r\ninterface VarInterface\t\t\r\nip netstream inbound \t\t\r\nip netstream outbound\r\n#\r\n#\r\nreturn\r\n";
            string ipFlowHuawei = "";
            string ipFlowFortigate = "config system netflow\r\nset collector-ip VarIPDestino\r\nset collector-port VarUDP\r\nend\r\n#\r\n#\r\nconfig system interface\t\r\nedit \"VarInterface\"\t\r\nset netflow-sampler both\r\nend\t\r\n#\t";
            #endregion

            // ------------------------------------------------- Port Block --------------------------------------------------------------
            #region
            string portBlockCisco = "conf t\r\n!\r\nip access-list extended ACL-BLOCK\r\n!\r\n!\r\n!#############################################################\r\n!BLOQUEIO IP DE WAN\r\n!#############################################################\r\n!\r\nVarWANftpDataVarWANftpLogVarWANsshVarWANdnsVarWANbootpsVarWANbootpcVarWANtftpVarWANwwwVarWANntpVarWANsnmpVarWANtrapVarWAN442tVarWAN443tVarWANcmdVarWAN4422VarWAN4433VarWANdhcpVarExtraWAN!\r\n!\r\n!\r\n!#############################################################\r\n!BLOQUEIO IP DE LAN\r\n!#############################################################\r\n!\r\nVarLANftpDataVarLANftpLogVarLANsshVarLANdnsVarLANbootpsVarLANbootpcVarLANtftpVarLANwwwVarLANntpVarLANsnmpVarLANtrapVarLAN442tVarLAN443tVarLANcmdVarLAN4422VarLAN4433VarLANdhcpVarExtraLAN!\r\n!\r\n!\r\npermit ip any any\r\n!\r\n!\r\n!\r\n!#############################################################\r\n! BLOQUEIO NA INTERFACE\r\n!#############################################################\r\n!\r\ninterface VarInterface\r\n  ip access-group ACL-BLOCK in\r\n!\r\n!\r\n!\r\nend";
            string portBlockHPE = "sys\r\n#\r\nacl advanced name ACL-BLOCK\r\n#\r\n#\r\n##############################################################\r\n# BLOQUEIO IP DE WAN\r\n##############################################################\r\n#\r\nVarWANftpDataVarWANftpLogVarWANsshVarWANdnsVarWANbootpsVarWANbootpcVarWANtftpVarWANwwwVarWANntpVarWANsnmpVarWANtrapVarWAN442tVarWAN443tVarWANcmdVarWAN4422VarWAN4433VarWANdhcpVarExtraWAN#\r\n#\r\n#\r\n##############################################################\r\n# BLOQUEIO IP DE LAN\r\n##############################################################\r\n#\r\nVarLANftpDataVarLANftpLogVarLANsshVarLANdnsVarLANbootpsVarLANbootpcVarLANtftpVarLANwwwVarLANntpVarLANsnmpVarLANtrapVarLAN442tVarLAN443tVarLANcmdVarLAN4422VarLAN4433VarLANdhcpVarExtraLAN#\r\n#\r\nrule 100 permit ip\r\n#\r\n#\r\n#\r\n##############################################################\r\n# BLOQUEIO NA INTERFACE + SSH\r\n##############################################################\r\n#\r\ninterface VarInterface\r\npacket-filter name ACL-BLOCK inbound\r\n#\r\n#\r\nsshServer\r\n#\r\n#\r\n#\r\nend";
            string portBlockHPEold = "system-view\r\nfirewall enable\r\n#\r\nacl number 3001\r\n#\r\n#\r\n##############################################################\r\n# CONFIGURAÇÃO PARA IP DE WAN\r\n##############################################################\r\n#\r\nVarWANftpDataVarWANftpLogVarWANsshVarWANdnsVarWANbootpsVarWANbootpcVarWANtftpVarWANwwwVarWANntpVarWANsnmpVarWANtrapVarWAN442tVarWAN443tVarWANcmdVarWAN4422VarWAN4433VarWANdhcpVarExtraWAN#\r\n#\r\n#\r\n##############################################################\r\n# CONFIGURAÇÃO PARA IP DE LAN\r\n##############################################################\r\n#\r\nVarLANftpDataVarLANftpLogVarLANsshVarLANdnsVarLANbootpsVarLANbootpcVarLANtftpVarLANwwwVarLANntpVarLANsnmpVarLANtrapVarLAN442tVarLAN443tVarLANcmdVarLAN4422VarLAN4433VarLANdhcpVarExtraLAN#\r\n#\r\nrule 100 permit ip\r\n#\r\n#\r\n#\r\n##############################################################\r\n# BLOQUEIO NA INTERFACE\r\n##############################################################\r\n#\r\ninterface VarInterface\r\nfirewall packet-filter 3001 inbound\r\n# \r\n#\r\nssh server enable\r\nssh server acl 3001\r\n#\r\n#\r\n#\r\nreturn";
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------- Add To List ----------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------

            List<Script> scriptList = new List<Script>();

            // Config
            Script scriptCiscoBLD = new Script(0, "Cisco-Config-BLD", false, ciscoBLD, "00,01,02,03,04,05,07,09,10", "", DateTime.Parse("11/02/2026"));
            Script scriptHpeBLD = new Script(1, "HPE-Config-BLD", false, hpeBLD, "00,01,02,03,04,05,07,09,10", "", DateTime.Parse("11/02/2026"));
            Script scriptHpeOldBLD = new Script(2, "HPE_old-Config-BLD", false, hpeOldBLD, "00,01,02,03,04,05,07,09,10", "", DateTime.Parse("11/02/2026"));
            Script scriptHuaweiBLD = new Script(3, "Huawei-Config-BLD", false, huaweiBLD, "00,01,02,03,04,05,07,09,10", "", DateTime.Parse("11/02/2026"));
            Script scriptFortigateBLD = new Script(4, "Fortigate-Config-BLD", false, fortigateBLD, "00,01,02,03,04,05,07,09,10", "", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoBLD);
            scriptList.Add(scriptHpeBLD);
            scriptList.Add(scriptHpeOldBLD);
            scriptList.Add(scriptHuaweiBLD);
            scriptList.Add(scriptFortigateBLD);

            Script scriptCiscoMPLS = new Script(5, "Cisco-Config-MPLS", false, ciscoMPLS, "00,01,02,03,04,05,07,09,12", "", DateTime.Parse("18/02/2026"));
            Script scriptHpeMPLS = new Script(6, "HPE-Config-MPLS", false, hpeMPLS, "00,01,02,03,04,05,07,09,12", "", DateTime.Parse("18/02/2026"));
            Script scriptHPEoldMPLS = new Script(7, "HPE_old-Config-MPLS", false, hpeOldMPLS, "00,01,02,03,04,05,07,09,12", "", DateTime.Parse("18/02/2026"));
            Script scriptHuaweiMPLS = new Script(8, "Huawei-Config-MPLS", false, huaweiMPLS, "00,01,02,03,04,05,07,08,09,12", "", DateTime.Parse("18/02/2026"));
            Script scriptFortigateMPLS = new Script(9, "Fortigate-Config-MPLS", false, fortigateMPLS, "00,01,02,03,04,05,07,09,11,12", "", DateTime.Parse("18/02/2026"));

            scriptList.Add(scriptCiscoMPLS);
            scriptList.Add(scriptHpeMPLS);
            scriptList.Add(scriptHPEoldMPLS);
            scriptList.Add(scriptHuaweiMPLS);
            scriptList.Add(scriptFortigateMPLS);

            Script scriptCiscoR2 = new Script(10, "Cisco-Config-VOZ-R2", false, ciscoR2, "00,01,02,03,04,05,07,09", "", DateTime.Parse("11/02/1999"));
            Script scriptCiscoR2ISR = new Script(11, "Cisco-Config-VOZ-R2 (ISR)", false, ciscoR2ISR, "00,01,02,03,04,05,07,09", "", DateTime.Parse("11/02/1999"));
            Script scriptCiscoPABX = new Script(12, "Cisco-Config-VOZ-PABXIP", false, ciscoPABX, "00,01,02,03,04,05,07,09", "", DateTime.Parse("18/02/2026"));
            Script scriptHpeR2 = new Script(13, "HPE-Config-VOZ-R2", false, hpeR2, "00,01,02,03,04,05,07,09", "", DateTime.Parse("11/02/1999"));
            Script scriptHpePABX = new Script(14, "HPE-Config-VOZ-PABXIP", false, hpePABX, "00,01,02,03,04,05,07,09", "", DateTime.Parse("18/02/2026"));
            Script scriptHpeOldR2 = new Script(15, "HPE_old-Config-VOZ-R2", false, hpeOldR2, "00,01,02,03,04,05,07,09", "", DateTime.Parse("11/02/1999"));
            Script scriptDigistar = new Script(16, "Digistar-Config-VOZ", false, digistar, "00,01,02,03,04,05,07,09", "", DateTime.Parse("11/02/1999"));
            Script scriptAligera561 = new Script(17, "Aligera561-Config-VOZ", false, aligera561, "00,07", "", DateTime.Parse("11/02/1999"));
            Script scriptAligera1600 = new Script(18, "Aligera1600-Config-VOZ", false, aligera1600, "00,07", "", DateTime.Parse("11/02/1999"));

            scriptList.Add(scriptCiscoR2);
            scriptList.Add(scriptCiscoR2ISR);
            scriptList.Add(scriptCiscoPABX);
            scriptList.Add(scriptHpeR2);
            scriptList.Add(scriptHpePABX);
            scriptList.Add(scriptHpeOldR2);
            scriptList.Add(scriptDigistar);
            scriptList.Add(scriptAligera561);
            scriptList.Add(scriptAligera1600);

            // Logs
            Script scriptCiscoLogsBLD = new Script(19, "Cisco-Log-BLD", false, ciscoLogsBLD, "03,04,05,06,07", "", DateTime.Parse("11/02/2026"));
            Script scriptHpeLogsBLD = new Script(20, "HPE-Log-BLD", false, hpeLogsBLD, "03,04,05,06,07,09", "", DateTime.Parse("11/02/2026"));
            Script scriptFortigateLogsBLD = new Script(21, "Fortigate-Log-BLD", false, fortigateLogsBLD, "03,05,07,09", "", DateTime.Parse("11/02/2026"));
            Script scriptHuaweiLogsBLD = new Script(22, "Huawei-Log-BLD", false, huaweiLogsBLD, "03,04,05,06,07,09", "", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoLogsBLD);
            scriptList.Add(scriptHpeLogsBLD);
            scriptList.Add(scriptFortigateLogsBLD);
            scriptList.Add(scriptHuaweiLogsBLD);

            Script scriptCiscoLogsMPLS = new Script(23, "Cisco-Log-MPLS", false, ciscoLogsMPLS, "03,04,05,06,07", "", DateTime.Parse("18/02/2026"));
            Script scriptHpeLogsMPLS = new Script(24, "HPE-Log-MPLS", false, hpeLogsMPLS, "03,04,05,06,07,09", "", DateTime.Parse("18/02/2026"));
            Script scriptFortigateLogsMPLS = new Script(25, "Fortigate-Log-MPLS", false, fortigateLogsMPLS, "03,05,07,09", "", DateTime.Parse("18/02/2026"));
            Script scriptHuaweiLogsMPLS = new Script(26, "Huawei-Log-MPLS", false, huaweiLogsMPLS, "03,04,05,06,07,09", "", DateTime.Parse("18/02/2026"));

            scriptList.Add(scriptCiscoLogsMPLS);
            scriptList.Add(scriptHpeLogsMPLS);
            scriptList.Add(scriptFortigateLogsMPLS);
            scriptList.Add(scriptHuaweiLogsMPLS);

            Script scriptCiscoLogsVOZ_R2 = new Script(27, "Cisco-Log-VOZ-R2", false, ciscoLogsVOZ, "03,04,05,07", "", DateTime.Parse("18/02/2026"));
            Script scriptHpeLogsVOZ_R2 = new Script(28, "HPE-Log-VOZ-R2", false, hpeLogsVOZ, "03,04,05,07,09", "", DateTime.Parse("18/02/2026"));
            Script scriptAligeraLogs = new Script(29, "Aligera-Log-VOZ", false, aligeraLogs, "07", "", DateTime.Parse("18/02/2026"));
            Script scriptDigistarLogs = new Script(30, "Digistar-Log-VOZ", false, digistarLogs, "07,03,04", "", DateTime.Parse("18/02/2026"));

            scriptList.Add(scriptCiscoLogsVOZ_R2);
            scriptList.Add(scriptHpeLogsVOZ_R2);
            scriptList.Add(scriptAligeraLogs);
            scriptList.Add(scriptDigistarLogs);

            // WizardGat
            Script scriptGatCiscoBLD = new Script(31, "Gat-Cisco-BLD", false, gatCiscoBLD, "03,08", "", DateTime.Parse("11/02/2026"));
            Script scriptGatCiscoMPLS = new Script(32, "Gat-Cisco-MPLS", false, gatCiscoMPLS, "03,08,14", "", DateTime.Parse("11/02/2026"));
            Script scriptGatCiscoVOZ = new Script(33, "Gat-Cisco-VOZ", false, gatCiscoVOZ, "03,08", "", DateTime.Parse("11/02/2026"));
            Script scriptGatCiscoBLDcomBGP = new Script(34, "Gat-Cisco-BLDcomBGP", false, gatCiscoBLDcomBGP, "03,08", "", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIABLD = new Script(35, "Gat-NOKIA-BLD", false, gatNOKIABLD, "03,07,08,13", "", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIAMPLS = new Script(36, "Gat-NOKIA-MPLS", false, gatNOKIAMPLS, "03,07,08,14,15,13", "", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIAVOZ = new Script(37, "Gat-NOKIA-VOZ", false, gatNOKIAVOZ, "03,07,08,13", "", DateTime.Parse("11/02/2026"));
            Script scriptGatNOKIABLDcomBGP = new Script(38, "Gat-NOKIA-BLDcomBGP", false, gatNOKIABLDcomBGP, "03,07,08,13", "", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptGatCiscoBLD);
            scriptList.Add(scriptGatCiscoMPLS);
            scriptList.Add(scriptGatCiscoVOZ);
            scriptList.Add(scriptGatCiscoBLDcomBGP);
            scriptList.Add(scriptGatNOKIABLD);
            scriptList.Add(scriptGatNOKIAMPLS);
            scriptList.Add(scriptGatNOKIAVOZ);
            scriptList.Add(scriptGatNOKIABLDcomBGP);

            // Outros
            // SNMP
            Script scriptSnmpv2Cisco = new Script(39, "snmpv2-Cisco", false, snmpv2Cisco, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2CiscoHost = new Script(40, "snmpv2-Cisco-Host", false, snmpv2CiscoHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2HPE = new Script(41, "snmpv2-HPE", false, snmpv2HPE, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2HPEcomHost = new Script(42, "snmpv2-HPE-ComHost", false, snmpv2HPEcomHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2Huawei = new Script(43, "snmpv2-Huawei", false, snmpv2Huawei, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2HuaweicomHost = new Script(44, "snmpv2-Huawei-ComHost", false, snmpv2HuaweicomHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2Fortgate = new Script(45, "snmpv2-Fortgate", false, snmpv2Fortgate, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));
            Script scriptSnmpv2FortgatecomHost = new Script(46, "snmpv2-Fortgate-ComHost", false, snmpv2FortgatecomHost, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptSnmpv2Cisco);
            scriptList.Add(scriptSnmpv2CiscoHost);
            scriptList.Add(scriptSnmpv2HPE);
            scriptList.Add(scriptSnmpv2HPEcomHost);
            scriptList.Add(scriptSnmpv2Huawei);
            scriptList.Add(scriptSnmpv2HuaweicomHost);
            scriptList.Add(scriptSnmpv2Fortgate);
            scriptList.Add(scriptSnmpv2FortgatecomHost);

            // Extras
            Script scriptCiscoLogsParte2 = new Script(47, "Cisco-Logs-Parte2", false, ciscoLogsParte2, "", "", DateTime.Parse("11/02/2026"));
            Script scriptCiscoLogsBLDLimpeza = new Script(48, "Cisco-Logs-LimpezaBLD", false, ciscoLogsBLDLimpeza, "", "", DateTime.Parse("11/02/2026"));
            Script scriptHPELogsParte2 = new Script(49, "HPE-Logs-Parte2", false, hpeLogsParte2, "", "", DateTime.Parse("11/02/2026"));
            Script scriptHPELogsBLDLimpeza = new Script(50, "HPE-Logs-LimpezaBLD", false, hpeLogsBLDLimpeza, "", "", DateTime.Parse("11/02/2026"));

            scriptList.Add(scriptCiscoLogsParte2);
            scriptList.Add(scriptCiscoLogsBLDLimpeza);
            scriptList.Add(scriptHPELogsParte2);
            scriptList.Add(scriptHPELogsBLDLimpeza);

            // QoS
            Script scriptQosCisco = new Script(51, "QoS Cisco", false, qosCisco, "", "", DateTime.Parse("23/02/2026"));
            Script scriptQosHPE = new Script(52, "QoS HPE", false, qosHPE, "", "", DateTime.Parse("23/02/2026"));
            Script scriptQosHuawei = new Script(53, "QoS Huawei", false, qosHuawei, "", "", DateTime.Parse("23/02/2026"));
            Script scriptQosFortigate = new Script(54, "QoS Fortigate", false, qosFortigate, "", "", DateTime.Parse("23/02/2026"));

            scriptList.Add(scriptQosCisco);
            scriptList.Add(scriptQosHPE);
            scriptList.Add(scriptQosHuawei);
            scriptList.Add(scriptQosFortigate);

            // BGP
            Script scriptBgpCisco = new Script(55, "QoS Cisco", false, bgpCisco, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("24/02/2026"));
            Script scriptBgpHPE = new Script(56, "QoS HPE", false, bgpHPE, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("24/02/2026"));
            Script scriptBgpHuawei = new Script(57, "QoS Huawei", false, bgpHuawei, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("24/02/2026"));
            Script scriptBgpFortigate = new Script(58, "QoS Fortigate", false, bgpFortigate, "Outros_VarText00,Outros_VarText01, Outros_VarText03", "", DateTime.Parse("24/02/2026"));

            scriptList.Add(scriptBgpCisco);
            scriptList.Add(scriptBgpHPE);
            scriptList.Add(scriptBgpHuawei);
            scriptList.Add(scriptBgpFortigate);

            // Regras Adicionais
            Script scriptRegraVozCisco = new Script(59, "Regra Voz Cisco", false, regraVozCisco, "", "", DateTime.Parse("07/04/2026"));
            Script scriptRegraVozCiscoISR = new Script(60, "Regra Voz Cisco ISR", false, regraVozCiscoISR, "", "", DateTime.Parse("07/04/2026"));
            Script scriptRegraVozHPE = new Script(61, "Regra Voz HPE", false, regraVozHPE, "", "", DateTime.Parse("07/04/2026"));
            Script scriptRegraVozAligera561 = new Script(62, "Regra Voz Aligera 561", false, regraVozAligera561, "", "", DateTime.Parse("07/04/2026"));
            Script scriptRegraVozAligera1600 = new Script(63, "Regra Voz Aligera 1600", false, regraVozAligera1600, "", "", DateTime.Parse("07/04/2026"));
            Script scriptRegraVozDigistar = new Script(64, "Regra Voz Digistar", false, regraVozDigistar, "", "", DateTime.Parse("07/04/2026"));

            scriptList.Add(scriptRegraVozCisco);
            scriptList.Add(scriptRegraVozCiscoISR);
            scriptList.Add(scriptRegraVozHPE);
            scriptList.Add(scriptRegraVozAligera561);
            scriptList.Add(scriptRegraVozAligera1600);
            scriptList.Add(scriptRegraVozDigistar);

            // VLAN
            Script scriptVlanCisco = new Script(65, "Vlan Cisco", false, vlanCisco, "", "", DateTime.Parse("17/03/2026"));
            Script scriptVlanCiscoCatalyst = new Script(66, "Vlan Cisco Catalyst", false, vlanCiscoCatalyst, "", "", DateTime.Parse("17/03/2026"));
            Script scriptVlanHPE = new Script(67, "Vlan HPE", false, vlanHPE, "", "", DateTime.Parse("17/03/2026"));
            Script scriptVlanHuawei = new Script(68, "Vlan Huawei", false, vlanHuawei, "", "", DateTime.Parse("17/03/2026"));
            Script scriptVlanFortigate = new Script(69, "Vlan Fortigate", false, vlanFortigate, "", "", DateTime.Parse("17/03/2026"));

            scriptList.Add(scriptVlanCisco);
            scriptList.Add(scriptVlanCiscoCatalyst);
            scriptList.Add(scriptVlanHPE);
            scriptList.Add(scriptVlanHuawei);
            scriptList.Add(scriptVlanFortigate);

            // DHCP
            Script scriptDhcpCisco = new Script(70, "DHCP Cisco", false, dhcpCisco, "", "", DateTime.Parse("17/03/2026"));
            Script scriptDhcpHPE = new Script(71, "DHCP HPE", false, dhcpHPE, "", "", DateTime.Parse("17/03/2026"));
            Script scriptDhcpHuawei = new Script(72, "DHCP Huawei", false, dhcpHuawei, "", "", DateTime.Parse("17/03/2026"));
            Script scriptDhcpFortigate = new Script(73, "DHCP Fortigate", false, dhcpFortigate, "", "", DateTime.Parse("17/03/2026"));

            scriptList.Add(scriptDhcpCisco);
            scriptList.Add(scriptDhcpHPE);
            scriptList.Add(scriptDhcpHuawei);
            scriptList.Add(scriptDhcpFortigate);

            // User
            Script scriptUserCisco = new Script(74, "User Cisco", false, userCisco, "", "", DateTime.Parse("17/03/2026"));
            Script scriptUserHPE = new Script(75, "User HPE", false, userHPE, "", "", DateTime.Parse("17/03/2026"));
            Script scriptUserHuawei = new Script(76, "User Huawei", false, userHuawei, "", "", DateTime.Parse("17/03/2026"));
            Script scriptUserFortigate = new Script(77, "User Fortigate", false, userFortigate, "", "", DateTime.Parse("17/03/2026"));

            scriptList.Add(scriptUserCisco);
            scriptList.Add(scriptUserHPE);
            scriptList.Add(scriptUserHuawei);
            scriptList.Add(scriptUserFortigate);

            // IP Flow
            Script scriptIpFlowCisco = new Script(78, "IP Flow Cisco", false, ipFlowCisco, "", "", DateTime.Parse("17/03/2026"));
            Script scriptIpFlowCiscoISR = new Script(79, "IP Flow Cisco ISR", false, ipFlowCiscoISR, "", "", DateTime.Parse("17/03/2026"));
            Script scriptIpFlowHPE = new Script(80, "IP Flow HPE", false, ipFlowHPE, "", "", DateTime.Parse("17/03/2026"));
            Script scriptIpFlowHuawei = new Script(81, "IP Flow Huawei", false, ipFlowHuawei, "", "", DateTime.Parse("17/03/2026"));
            Script scriptIpFlowFortigate = new Script(82, "IP Flow Fortigate", false, ipFlowFortigate, "", "", DateTime.Parse("17/03/2026"));

            scriptList.Add(scriptIpFlowCisco);
            scriptList.Add(scriptIpFlowCiscoISR);
            scriptList.Add(scriptIpFlowHPE);
            scriptList.Add(scriptIpFlowHuawei);
            scriptList.Add(scriptIpFlowFortigate);

            // Port Block
            Script scriptPortBlockCisco = new Script(83, "Port Block Cisco", false, portBlockCisco, "", "", DateTime.Parse("17/03/2026"));
            Script scriptPortBlockHPE = new Script(84, "Port Block HPE", false, portBlockHPE, "", "", DateTime.Parse("17/03/2026"));
            Script scriptPortBlockHPEold = new Script(85, "Port Block Cisco", false, portBlockHPEold, "", "", DateTime.Parse("17/03/2026"));

            scriptList.Add(scriptPortBlockCisco);
            scriptList.Add(scriptPortBlockHPE);
            scriptList.Add(scriptPortBlockHPEold);


            // -----------------------------------------------------
            return scriptList;
        }
    }
}
