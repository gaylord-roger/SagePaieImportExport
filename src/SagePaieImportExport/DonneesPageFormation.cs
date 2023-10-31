using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// FM
    /// </summary>
    [FixedLengthFile]
    public class DonneesPageFormation
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "FM";

        [StringField(2, 10)]
        public string Matricule { get; set; }

        [EnumField(3)]
        public Civilite Civilite { get; set; }

        [StringField(4, 30)]
        public string Nom { get; set; }

        [StringField(5, 20)]
        public string Prenom { get; set; }

        [StringField(6, 5)]
        public string Etablissement { get; set; }

        [StringField(7, 2)]
        public string ZoneReservee { get; set; }

        [EnumField(8)]
        public CategorieFormationProfessionelle CategorieFormationProfessionelle { get; set; }

        [StringField(9, 12)]
        public string HoraireFormation { get; set; }

        [StringField(10, 12)]
        public string HoraireHebdomadaire { get; set; }

        [StringField(11, 2)]
        public string ZoneReservee2 { get; set; }

        [EnumField(12)]
        public NiveauEtude NiveauEtude { get; set; }
    }
}
