using SagePaieImportExport.Enums;
using SagePaieImportExport.Attributes;

namespace SagePaieImportExport
{
    /// <summary>
    /// 07
    /// </summary>
    [FixedLengthFile]
    public class DonneesBanque
    {
        [StringField(1, 2)]
        public string Id { get; private set; } = "07";

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

        [EnumField(7)]
        public ModePaiement ModePaiement { get; set; }

        [EnumField(8)]
        public BanqueSalarie ChoixBanqueSalarie { get; set; }

        [EnumField(9)]
        public BanqueEtablissementPayeur ChoixBanqueEtablissementPayeur { get; set; }

        [StringField(10, 5)]
        public string CodeBanque1 { get; set; }

        [StringField(11, 5)]
        public string CodeGuichet1 { get; set; }

        [StringField(12, 11)]
        public string NumeroCompte1 { get; set; }

        [StringField(13, 2)]
        public string Cle1 { get; set; }

        [StringField(14, 24)]
        public string LibelleCompte1 { get; set; }

        [StringField(15, 30)]
        public string NomGuichet1 { get; set; }

        [StringField(16, 30)]
        public string NomBanque1 { get; set; }

        [StringField(17, 5)]
        public string CodeBanque2 { get; set; }

        [StringField(18, 5)]
        public string CodeGuichet2 { get; set; }

        [StringField(19, 11)]
        public string NumeroCompte2 { get; set; }

        [StringField(20, 2)]
        public string Cle2 { get; set; }

        [StringField(21, 24)]
        public string LibelleCompte2 { get; set; }

        [StringField(22, 30)]
        public string NomGuichet2 { get; set; }

        [StringField(23, 30)]
        public string NomBanque2 { get; set; }

        [DecimalField(24, 12)]
        public decimal ValeurFixePaiement { get; set; }

        [IntField(25, 1)]
        public int PaiementFixePourcent { get; set; }

        [EnumField(26)]
        public ChoixBanqueSalariePaiementFixe BanqueSalariePaiementFixe { get; set; }

        [EnumField(27, 1)]
        public TypeCoordonneeBanque Banque1TypeCoordonneeBanque { get; set; }

        [StringField(28, 3)]
        public string Banque1CodePays { get; set; }

        [StringField(29, 11)]
        public string Banque1BIC { get; set; }

        [StringField(30, 42)]
        public string Banque1IBAN { get; set; }

        [EnumField(31, 1)]
        public TypeCoordonneeBanque Banque2TypeCoordonneeBanque { get; set; }

        [StringField(32, 3)]
        public string Banque2CodePays { get; set; }

        [StringField(33, 11)]
        public string Banque2BIC { get; set; }

        [StringField(34, 42)]
        public string Banque2IBAN { get; set; }
    }
}
