using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;
using System;

namespace SagePaieImportExport
{
    /// <summary>
    /// GC
    /// </summary>
    [FixedLengthFile]
    public class DonneesPageCarriere
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "GC";

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

        [StringField(7, 10)]
        public string MatriculeSuperieurHierarchique { get; set; }

        [StringField(8, 2)]
        public string ResponsabiliteHierarchique { get; set; }

        [StringField(9, 10)]
        public string MatriculeSuppleant1 { get; set; }

        [StringField(10, 10)]
        public string MatriculeSuppleant2 { get; set; }

        [StringField(11, 10)]
        public string MatriculeAssistant { get; set; }

        [StringField(12, 10)]
        public string EmploiOccupe { get; set; }
    }
}
