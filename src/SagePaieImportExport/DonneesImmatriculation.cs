using SagePaieImportExport.Attributes;
using SagePaieImportExport.Enums;

namespace SagePaieImportExport
{
    /// <summary>
    /// 01
    /// </summary>
    [FixedLengthFile]
    public class DonneesImmatriculation
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "01";

        [StringField(2, 10)]
        public string Matricule { get; set; }

        [StringField(3, 1)]
        public string ZoneReservee1 { get; private set; } = " ";

        [EnumField(4)]
        public Civilite Civilite { get; set; }

        [StringField(5, 30)]
        public string Nom { get; set; }

        [StringField(6, 30)]
        public string NomJeuneFille { get; set; }

        [StringField(7, 20)]
        public string Prenom { get; set; }

        [StringField(8, 20)]
        public string AutresPrenoms { get; set; }

        [StringField(9, 32)]
        public string Adresse1 { get; set; }

        [StringField(10, 32)]
        public string Adresse1Complement { get; set; }

        [StringField(11, 26)]
        public string Adresse1Commune { get; set; }

        [StringField(12, 5)]
        public string Adresse1CodePostal { get; set; }

        [StringField(13, 26)]
        public string Adresse1BureauDistributeur { get; set; }

        [StringField(14, 15)]
        public string Adresse1Telephone { get; set; }

        [StringField(15, 32)]
        public string Adresse2 { get; set; }

        [StringField(16, 32)]
        public string Adresse2Complement { get; set; }

        [StringField(17, 26)]
        public string Adresse2Commune { get; set; }

        [StringField(18, 5)]
        public string Adresse2CodePostal { get; set; }

        [StringField(19, 26)]
        public string Adresse2BureauDistributeur { get; set; }

        [StringField(20, 15)]
        public string Adresse2Telephone { get; set; }

        // 387
        [EnumField(21)]
        public BanqueSalarie ChoixAdresseSurBulletin { get; set; }

        [StringField(22, 5)]
        public string Etablissement { get; set; }

        [StringField(23, 13)]
        public string CompteAuxiliaire { get; set; }

        [StringField(24, 5)]
        public string Adresse1CodeInsee { get; set; }

        [StringField(25, 3)]
        public string Adresse1CodePays { get; set; }

        [StringField(26, 13)]
        public string IdentifiantDeLepargneSalariale { get; set; }

        [StringField(27, 2)]
        public string IdentifiantDeLepargneSalarialeCle { get; set; }

        // 429
        [BoolField(28)]
        public bool ResidentFiscal { get; set; }

        [BoolField(29)]
        public bool SoumisCsg { get; set; }

        [StringField(30, 80)]
        public string NomComplet { get; set; }

        [StringField(31, 80)]
        public string NomDeJeuneFilleComplet { get; set; }

        [StringField(32, 128)]
        public string AdresseCourriel { get; set; }

        [StringField(33, 15)]
        public string Portable { get; set; }

        [IntField(34, 2)]
        public byte Confidentialite { get; set; }

        [StringField(35, 30)]
        public string NomPersonne1APrevenirEnCasAccident { get; set; }

        [StringField(36, 15)]
        public string TelPersonne1APrevenirEnCasAccident { get; set; }

        [StringField(37, 30)]
        public string NomPersonne2APrevenirEnCasAccident { get; set; }

        [StringField(38, 15)]
        public string TelPersonne2APrevenirEnCasAccident { get; set; }

        [StringField(39, 50)]
        public string CodeDistributionEtranger { get; set; }
    }
}
