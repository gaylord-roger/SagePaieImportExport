using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;

namespace SagePaieImportExport
{
    /// <summary>
    /// 06
    /// </summary>
    [FixedLengthFile]
    public class DonneesConges
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "06";

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

        [StringField(7, 615)]
        public string ZoneReservee { get; set; }
    }
}
