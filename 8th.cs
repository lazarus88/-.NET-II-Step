using System.Net.Http.Headers;
GenerateCountryDataFiles();
void GenerateCountryDataFiles()
{
    HttpClient con = new HttpClient();
    con.BaseAddress = new Uri($"https://restcountries.com/v3.1/all");
    con.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage acc = con.GetAsync("").Result;
    if (acc.IsSuccessStatusCode)
    {
        var dt = acc.Content.ReadAsAsync<IEnumerable<shmeyana>>().Result;
        foreach (var yana in dt)
        {
            string file = "" + yana.name.gvari + ".txt";
            try
            {
                if (File.Exists(file)) File.Delete(file);
                using (StreamWriter gvss = File.CreateText(file))
                {
                    gvss.WriteLine(" : " + yana.region + " : " + yana.subregion +
                        " : " +  yana.latlng[0] + "|" + yana.latlng[1] +
                        " : " + yana.area +" : " + yana.population);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString);
            }
        }
    }
    con.Dispose();
}
public class shmeyana
{
    public name name { get; set; }
    public String region { get; set; }
    public String subregion { get; set; }
    public double[] latlng { get; set; }
    public double area { get; set; }
    public int population { get; set; }

}
public class name
{
    public String gvari { get; set; }
}
