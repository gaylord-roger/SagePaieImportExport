using System;
using System.Collections.Generic;
using System.Text;

namespace SagePaieImportExport
{
    public class FichePersonnelle
    {
        public DonneesImmatriculation Immatriculation { get; set; }
        public DonneesEtatCivil EtatCivil { get; set; }
        public DonneesLieuTravail LieuTravail { get; set; }
        public DonneesAffectation Affectation { get; set; }
        public DonneesSalaire Salaire { get; set; }
        public DonneesConges Conges { get; set; }
        public DonneesBanque Banque { get; set; }
        public DonneesDADS DADS { get; set; }
        public DonneesFiscales Fiscales { get; set; }
        public DonneesBilanSocial BilanSocial { get; set; }
        public DonneesPersonnelles Personnelles { get; set; }
        public DonneesZonesLibres ZonesLibres { get; set; }
        public IEnumerable<DonneesRP> RP { get; set; }
        public DonneesPageTemps PageTemps { get; set; }
        public DonneesPageFormation PageFormation { get; set; }
        public DonneesPageCarriere PageCarriere { get; set; }
        public IEnumerable<DonneesPageCarriereCompetence> PageCarriereCompetences { get; set; }
        public DonneesDADSU DADSU { get; set; }
        public DonneesSalarie Salarie { get; set; }
    }
}
