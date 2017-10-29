﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JgDatevExportLib
{
    public class DatevEnum
    {
        public enum EnumDatevFormat : byte
        {
            EXTF,
            DTVF
        }

        public enum EnumDatenkategorie : byte
        {
            Buchungsstapel = 21,
            WiederkehrendeBuchungen = 65,
            Buchungskonstanten = 67,
            Sachkongenbeschriftungen = 20,
            KontoNotizen = 47,
            DebitorenKreditoren = 16,
            Textschlüssel = 44,
            Zahlungsbedingungen = 46,
            DiverseAdressen = 48,
            BuchungssaetzeAnlagenbuchfuehrung = 63,
            FilialenAnlagenbuchfuehrung = 62
        }

        public enum EnumFormatname : byte
        {
            Buchungsstapel,
            Wiederkehrende_Buchungen,
            Buchungstextkonstanten,
            Kontenbeschriftungen,
            Debitoren__Kreditoen,       // __ => /
            Textschlüsssel,
            Zahlungsbedingungen,
            Diverse_Adressen,
            Anlagenbuchführung___Buchungssatzvorlagen,  // ___ => -
            Anlagenbuchführung___Filialen               // ___ => -
        }

        public enum EnumFormatversion : byte
        {
            Buchungsstapel_7,
            WiderkehrendeBuchungen_2,
            Buchungstextkonstanten_1,
            Kontenberschriftungen_2,
            KontoNotizen_1,
            DebitorenKreditoren_4,
            Textschlüssel_2,
            Zahlungsbedingungen_2,
            DiverseAdressen_2,
            BuchungssätzeAnlagenbuchführung_1,
            FilialenAnlagenbuchflührung_1
        }

        public enum EnumBuchungstyp : byte
        {
            Finanzbuchführung = 1,
            Jahresabschluss = 2,
            leer = 254
        }

        public enum EnumRechnungszweck : byte
        {
            Unabhängig = 0,
            Handelsrecht = 50,
            Steuerrecht = 30,
            IFRS = 64,
            Kalkulatorik = 40,
            Reserviert11 = 11,
            Reserviert12 = 12
        }

        public enum EnumFestschreibung : byte
        {
            KeineFestschreibung = 0,
            Festschreibung = 1,
            leer = 254
        }

        public enum EnumSachkontenNummernLaenge : byte
        {
            Stellen_4 = 4,
            Stellen_8 = 8
        }

        public enum EnumSollHaben : byte
        {
            Soll,
            Haben
        }

        public enum EnumWaehrung : byte
        {
            EUR,
            CZK,
            PLN,
            NLG,
            RUB,

            leer = 254
        }

        public enum EnumPostensperre : byte
        {
            keineSperre = 0,
            Postensperre = 1,

            leer = 254
        }

        public enum EnumZissperre : byte
        {
            keineSperre = 0,
            Zinssperre = 1,

            leer = 254
        }

        public enum EnumAbwVersteuerungsart : byte
        {
            IstVersteuerung,
            KeineUmsatzsteuerrechnung,
            Pauschalierung,
            SollVersteuerung,

            leer = 254
        }

        public enum EnumZahlweise : byte
        {
            Lastschrift = 1,
            Mahnung = 2,
            Zahlung = 3,

            leer = 254
        }
    }
}
