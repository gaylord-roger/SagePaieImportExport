using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;

namespace SagePaieImportExport
{
    /// <summary>
    /// 10
    /// </summary>
    [FixedLengthFile]
    public class DonneesBilanSocial
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "10";

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

        // TODO
    }
}
