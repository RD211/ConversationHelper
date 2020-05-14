using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public partial class Followup
{
    [JsonProperty("reply", NullValueHandling = NullValueHandling.Ignore)]
    public string Reply { get; set; }

    [JsonProperty("playerResponse", NullValueHandling = NullValueHandling.Ignore)]
    public string PlayerResponse { get; set; }

    [JsonProperty("followup", NullValueHandling = NullValueHandling.Ignore)]
    public List<Followup> Followups { get; set; }
    public Followup()
    {
        this.Reply = "";
        this.PlayerResponse = "";
        this.Followups = new List<Followup>();
    }
}



