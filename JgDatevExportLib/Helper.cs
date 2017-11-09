﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace JgDatevExportLib
{
    public static class Helper
    {
        public static string Konvert(object Wert, string Format = null)
        {
            if (Wert != null)
            {
                var t = Wert.GetType();

                if (t == typeof(string))
                    return "\"" + Wert.ToString().Replace("\"", "\"\"") + "\"";
                else if (t == typeof(DateTime))
                    return ((DateTime)Wert).ToString(Format);
                else if ((t == typeof(int)) || ((t == typeof(long))))
                    return Wert.ToString();
                else
                {
                    if (Wert.ToString() == "leer")
                        return "";
                    else
                      return (Convert.ToByte(Wert)).ToString();
                }
            }

            return "";
        }

        public static string GetNameConfigDatei()
        {
            var dat = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return System.IO.Path.GetDirectoryName(dat) + @"\JgDatevExport.config";
        }

        public static string UnterstricheInWert(string Wert)
        {
            return Wert.Replace("_", " ").Replace("__", "//").Replace("___", "-");
        }

        public static string DateinameErstellen(string DateiName, DateTime Datum)
        {
            return "EXTF_" + DateiName + "_" + Datum.ToString("ddMMyy_mmHH") + ".csv";
        }

        public static void DatenSpeichern(string DateiName, DatevHeader Header, DatevKoerper Koerper)
        {
            var arrList = new ArrayList();
            arrList.Add(Header);
            arrList.Add(Koerper);

            var fs = new FileStream(DateiName, FileMode.Create);
            var formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(fs, arrList);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static (DatevHeader Header, DatevKoerper Koerper) DatenLaden(string Dateiname)
        {
            var fs = new FileStream(Dateiname, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var arrList = (ArrayList)formatter.Deserialize(fs);

                DatevHeader header = null;
                DatevKoerper koerper = null;

                foreach (var obj in arrList)
                {
                    if (obj is DatevHeader)
                        header = (DatevHeader)obj;
                    else if (obj is DatevKoerper)
                        koerper = (DatevKoerper)obj;
                }

                return (header, koerper);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
