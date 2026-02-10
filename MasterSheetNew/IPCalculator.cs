using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSheetNew
{
    internal class IPCalculator
    {

        public string ApplyIPCalculator(string enterString)
        {
            try
            {
                string[] SplitString = enterString.Split('/');

                string ipStr = SplitString[0];
                string subnet = SplitString[1];

                if (subnet == "32")
                {
                    subnet = "255.255.255.255";
                }
                else if (subnet == "31")
                {
                    subnet = "255.255.255.254";
                }
                else if (subnet == "30")
                {
                    subnet = "255.255.255.252";
                }
                else if (subnet == "29")
                {
                    subnet = "255.255.255.248";
                }
                else if (subnet == "28")
                {
                    subnet = "255.255.255.240";
                }
                else if (subnet == "27")
                {
                    subnet = "255.255.255.224";
                }
                else if (subnet == "26")
                {
                    subnet = "255.255.255.192";
                }
                else if (subnet == "25")
                {
                    subnet = "255.255.255.128";
                }
                else if (subnet == "24")
                {
                    subnet = "255.255.255.0";
                }
                else if (subnet == "23")
                {
                    subnet = "255.255.254.0";
                }
                else if (subnet == "22")
                {
                    subnet = "255.255.252.0";
                }
                else if (subnet == "21")
                {
                    subnet = "255.255.248.0";
                }
                else if (subnet == "20")
                {
                    subnet = "255.255.240.0";
                }
                else if (subnet == "19")
                {
                    subnet = "255.255.224.0";
                }
                else if (subnet == "18")
                {
                    subnet = "255.255.192.0";
                }
                else if (subnet == "17")
                {
                    subnet = "255.255.128.0";
                }
                else if (subnet == "16")
                {
                    subnet = "255.255.0.0";
                }
                else if (subnet == "15")
                {
                    subnet = "255.254.0.0";
                }
                else if (subnet == "14")
                {
                    subnet = "255.252.0.0";
                }
                else if (subnet == "13")
                {
                    subnet = "255.248.0.0";
                }
                else if (subnet == "12")
                {
                    subnet = "255.240.0.0";
                }
                else if (subnet == "11")
                {
                    subnet = "255.224.0.0";
                }
                else if (subnet == "10")
                {
                    subnet = "255.192.0.0";
                }
                else if (subnet == "9")
                {
                    subnet = "255.128.0.0";
                }
                else if (subnet == "8")
                {
                    subnet = "255.0.0.0";
                }
                else if (subnet == "7")
                {
                    subnet = "254.0.0.0";
                }
                else if (subnet == "6")
                {
                    subnet = "252.0.0.0";
                }
                else if (subnet == "5")
                {
                    subnet = "248.0.0.0";
                }
                else if (subnet == "4")
                {
                    subnet = "240.0.0.0";
                }
                else if (subnet == "3")
                {
                    subnet = "224.0.0.0";
                }
                else if (subnet == "2")
                {
                    subnet = "192.0.0.0";
                }
                else if (subnet == "1")
                {
                    subnet = "128.0.0.0";
                }
                else if (subnet == "0")
                {
                    subnet = "0.0.0.0";
                }
                else
                {
                    subnet = string.Empty;
                }

                return CalculateIP(ipStr, subnet);
            }
            catch (Exception e)
            {
                MessageBox.Show("IP + Máscara incorretos");

                return "Erro";
            }
        }

        public string CalculateIP(string ipAddress, string subnetMask)
        {
            string t = "";

            if (subnetMask == string.Empty)
            {
                MessageBox.Show("Máscara Incorreta");
            }
            else
            {
                uint ip = ToUint(IPAddress.Parse(ipAddress));
                uint mask = ToUint(IPAddress.Parse(subnetMask));

                // Calcular Rede e Broadcast
                uint network = ip & mask;
                uint broadcast = network | ~mask;

                t = ($"IP: {ipAddress}\n") +
                        ($"Máscara: {subnetMask}\n") +
                        ($"Rede: {ToIP(network)}\n") +
                        ($"Broadcast: {ToIP(broadcast)}\n\n");

                if (subnetMask != "255.255.255.255" && subnetMask != "255.255.255.254" && subnetMask != "0.0.0.0")
                {
                    // ------------------------------------------
                    t = t + ($"Range de IPs Disponiveis: \n") +
                            ($"Inicio: {ToIP(network + 1)}\n") +
                            ($"Fim: {ToIP(broadcast - 1)}\n") +
                            ($"Número Total: {(broadcast + 1) - network}\n");
                }
                else
                {
                    if (subnetMask != "255.255.255.255")
                    {
                        // ------------------------------------------
                        t = t + ($"Range de IPs Disponiveis: \n") +
                                ($"Inicio: {ToIP(broadcast)}\n") +
                                ($"Fim: {ToIP(broadcast)}\n") +
                                ($"Número Total: {1}\n");
                    }
                    else if (subnetMask != "255.255.255.254")
                    {
                        // ------------------------------------------
                        t = t + ($"Range de IPs Disponiveis: \n") +
                                ($"Inicio: {ToIP(network)}\n") +
                                ($"Fim: {ToIP(broadcast)}\n") +
                                ($"Número Total: {2}\n");
                    }
                    else if (subnetMask != "0.0.0.0")
                    {
                        // ------------------------------------------
                        t = t + ($"Range de IPs Disponiveis: \n") +
                                ($"Inicio: {ToIP(broadcast)}\n") +
                                ($"Fim: {ToIP(broadcast)}\n") +
                                ($"Número Total: 4.294.967.296\n");
                    }

                }
            }

            return t;
        }

        static uint ToUint(IPAddress ip)
        {
            byte[] bytes = ip.GetAddressBytes();
            Array.Reverse(bytes); // Converter para Network Byte Order (Big Endian)
            return BitConverter.ToUInt32(bytes, 0);
        }

        static string ToIP(uint intIp)
        {
            byte[] bytes = BitConverter.GetBytes(intIp);
            Array.Reverse(bytes);
            return new IPAddress(bytes).ToString();
        }
    }
}
