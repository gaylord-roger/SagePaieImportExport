using SagePaieImportExport;

internal class Program
{
    static async Task Main(string[] args)
    {
        var paie = new ImportExport();

        Console.WriteLine(paie.DecrireFormat());

        await paie.ReadFileAsync("0001.txt");
        Console.Write(paie.Dump());

        await paie.WriteFileAsync("0002.txt",
            new object[] {
                paie.Immatriculation,
                paie.EtatCivil,
                paie.LieuTravail,
                paie.Affectation,
                paie.Salaire,
                paie.Conges,
                paie.Banque,
                paie.DADS,
                paie.Fiscales,
                paie.BilanSocial,
                paie.Personnelles,
                paie.ZonesLibres,
                paie.DADSU,
                paie.RP,
                paie.PageFormation,
                paie.PageTemps,
                paie.PageCarriere
            });

    }
}

static class Ext
{
    static readonly System.Text.Json.JsonSerializerOptions opts = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
    public static string Dump(this object o) => System.Text.Json.JsonSerializer.Serialize(o, opts);
}