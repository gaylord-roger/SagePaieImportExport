using FluentFiles.Core;
using FluentFiles.FixedLength;
using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SagePaieImportExport
{
    public class ImportExport
    {
        private readonly IFlatFileMultiEngine flatFile;

        public Encoding FileEncoding { get; set; } = Encoding.GetEncoding("ISO-8859-1");

        public ImportExport()
        {
            var factory = new FixedLengthFileEngineFactory();
            flatFile = factory.GetEngine(new Type[] {
                typeof(DonneesImmatriculation),
                typeof(DonneesEtatCivil),
                typeof(DonneesLieuTravail),
                typeof(DonneesAffectation),
                typeof(DonneesSalaire),
                typeof(DonneesBanque),
                typeof(DonneesConges),
                typeof(DonneesDADS),
                typeof(DonneesFiscales),
                typeof(DonneesBilanSocial),
                typeof(DonneesPersonnelles),
                typeof(DonneesSalarie),
                typeof(DonneesZonesLibres),
                typeof(DonneesRP),
                typeof(DonneesPageTemps),
                typeof(DonneesPageFormation),
                typeof(DonneesPageCarriere),
                typeof(DonneesPageCarriereCompetence),
                typeof(DonneesDADSU),
        },
            (str, idx) =>
            {
                var id = str.Substring(0, 2);
                switch (id)
                {
                    case "01": return typeof(DonneesImmatriculation);
                    case "02": return typeof(DonneesEtatCivil);
                    case "03": return typeof(DonneesLieuTravail);
                    case "04": return typeof(DonneesAffectation);
                    case "05": return typeof(DonneesSalaire);
                    case "06": return typeof(DonneesConges);
                    case "07": return typeof(DonneesBanque);
                    case "08": return typeof(DonneesDADS);
                    case "09": return typeof(DonneesFiscales);
                    case "10": return typeof(DonneesBilanSocial);
                    case "11": return typeof(DonneesPersonnelles);
                    case "14": return typeof(DonneesSalarie);
                    case "ZL": return typeof(DonneesZonesLibres);
                    case "RP": return typeof(DonneesRP);
                    case "GT": return typeof(DonneesPageTemps);
                    case "FM": return typeof(DonneesPageFormation);
                    case "GC": return typeof(DonneesPageCarriere);
                    case "DU": return typeof(DonneesDADSU);
                }

                return null;
            });
        }

        public string DecrireFormat()
        {
            StringBuilder sb = new StringBuilder();

            var fieldInfo = typeof(FixedLengthFileMultiEngine).GetField("_layoutDescriptors", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            Dictionary<Type, IFixedLengthLayoutDescriptor> _layoutDescriptors = fieldInfo.GetValue(flatFile) as Dictionary<Type, IFixedLengthLayoutDescriptor>;

            foreach (var layout in _layoutDescriptors)
            {
                sb.AppendLine(">>" + layout.Key.Name);
                var idx = 1;
                foreach (var f in layout.Value.Fields.OrderBy(f => f.Index))
                {
                    sb.AppendLine("  " + idx.ToString().PadLeft(5) + " " + f.Length.ToString().PadLeft(3) + " " + f.UniqueKey.Substring(f.UniqueKey.LastIndexOf(':') + 1));
                    idx += f.Length;
                }
            }

            return sb.ToString();
        }

        public DonneesImmatriculation Immatriculation => flatFile.GetRecords<DonneesImmatriculation>().FirstOrDefault();
        public DonneesEtatCivil EtatCivil => flatFile.GetRecords<DonneesEtatCivil>().FirstOrDefault();
        public DonneesLieuTravail LieuTravail => flatFile.GetRecords<DonneesLieuTravail>().FirstOrDefault();
        public DonneesAffectation Affectation => flatFile.GetRecords<DonneesAffectation>().FirstOrDefault();
        public DonneesSalaire Salaire => flatFile.GetRecords<DonneesSalaire>().FirstOrDefault();
        public DonneesConges Conges => flatFile.GetRecords<DonneesConges>().FirstOrDefault();
        public DonneesBanque Banque => flatFile.GetRecords<DonneesBanque>().FirstOrDefault();
        public DonneesDADS DADS => flatFile.GetRecords<DonneesDADS>().FirstOrDefault();
        public DonneesFiscales Fiscales => flatFile.GetRecords<DonneesFiscales>().FirstOrDefault();
        public DonneesBilanSocial BilanSocial => flatFile.GetRecords<DonneesBilanSocial>().FirstOrDefault();
        public DonneesPersonnelles Personnelles => flatFile.GetRecords<DonneesPersonnelles>().FirstOrDefault();
        public DonneesZonesLibres ZonesLibres => flatFile.GetRecords<DonneesZonesLibres>().FirstOrDefault();
        public IEnumerable<DonneesRP> RP => flatFile.GetRecords<DonneesRP>();
        public DonneesPageTemps PageTemps => flatFile.GetRecords<DonneesPageTemps>().FirstOrDefault();
        public DonneesPageFormation PageFormation => flatFile.GetRecords<DonneesPageFormation>().FirstOrDefault();
        public DonneesPageCarriere PageCarriere => flatFile.GetRecords<DonneesPageCarriere>().FirstOrDefault();
        public IEnumerable<DonneesPageCarriereCompetence> PageCarriereCompetences => flatFile.GetRecords<DonneesPageCarriereCompetence>();
        public DonneesDADSU DADSU => flatFile.GetRecords<DonneesDADSU>().FirstOrDefault();
        public DonneesSalarie Salarie => flatFile.GetRecords<DonneesSalarie>().FirstOrDefault();
        
        public async Task ReadFileAsync(string path, CancellationToken cancellationToken = default)
        {
            using (var stream = File.OpenRead(path))
            {
                using (var sr = new StreamReader(stream, FileEncoding))
                {
                    await ReadAsync(sr, cancellationToken);
                }
            }
        }

        public async Task WriteFileAsync(string path, IEnumerable<object> donnees, CancellationToken cancellationToken = default)
        {
            using (var stream = File.OpenWrite(path))
            {
                using (var sw = new StreamWriter(stream, FileEncoding))
                {
                    await WriteAsync(sw, donnees, cancellationToken);

                    stream.Flush();
                    stream.SetLength(stream.Position);
                }
            }
        }

        public Task ReadAsync(TextReader reader, CancellationToken cancellationToken = default) =>
            flatFile.ReadAsync(reader, cancellationToken);

        public Task WriteAsync<T>(TextWriter writer, T donnees, CancellationToken cancellationToken = default) where T : class, new() =>
            flatFile.WriteAsync(writer, new T[] { donnees }, cancellationToken);

        public Task WriteAsync<T>(TextWriter writer, IEnumerable<T> donnees, CancellationToken cancellationToken = default) where T : class, new() =>
            flatFile.WriteAsync(writer, donnees, cancellationToken);

        public Task WriteAsync(TextWriter writer, IEnumerable<object> donnees, CancellationToken cancellationToken = default) =>
            flatFile.WriteAsync(writer, donnees, cancellationToken);
    }
}
