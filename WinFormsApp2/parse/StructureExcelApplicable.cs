using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.parse
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Root
    {
        public ResultExcel result { get; set; } = new ResultExcel();
    }

    public class ResultExcel
    {
        public MiInfo miInfo { get; set; } = new MiInfo();
        public VriInfo vriInfo { get; set; } = new VriInfo();
        public Info info { get; set; } = new Info();
        public Publication publication { get; set; } = new Publication();
    }

    public class MiInfo
    {
        public EtaMI etaMI { get; set; } = new EtaMI();
        public SingleMI singleMI { get; set; } = new SingleMI();
    }

    public class EtaMI
    {
        public string regNumber { get; set; } = "";
        public string mitypeNumber { get; set; } = "";
        public string mitypeURL { get; set; } = "";
        public string mitypeTitle { get; set; } = "";
        public string mitypeType { get; set; } = "";
        public string modification { get; set; } = "";
        public string manufactureNum { get; set; } = "";
        public int manufactureYear { get; set; } = 0;
        public string rankCode { get; set; } = "";
        public string rankTitle { get; set; } = "";
        public string schemaTitle { get; set; } = "";
    }

    public class SingleMI
    {
        public string mitypeNumber { get; set; } = "";
        public string mitypeType { get; set; } = "";
        public string mitypeTitle { get; set; } = "";
        public string manufactureNum { get; set; } = "";
        public string inventoryNum { get; set; } = "";
        public int manufactureYear { get; set; } = 0;
        public string modification { get; set; } = "";
    }

    public class VriInfo
    {
        public string organization { get; set; } = "";
        public string miOwner { get; set; } = "";
        public string vrfDate { get; set; } = "";
        public string validDate { get; set; } = "";
        public string vriType { get; set; } = "";
        public string docTitle { get; set; } = "";
        public Applicable applicable { get; set; } = new Applicable();
        public InApplicable inaplicable { get; set; } = new InApplicable();

        
    }

    public class Applicable
    {
        public string certNum { get; set; } = "";

        public Applicable() { certNum = "";}
    }

    public class InApplicable
    {
        public string noticeNum { get; set; } = "";

        public InApplicable() { noticeNum = ""; }
    }

    public class Info
    {
        public string structure { get; set; } = "";
        public bool briefIndicator { get; set; }
        public string briefCharacteristics { get; set; } = "";
        public string ranges { get; set; } = "";
        public string values { get; set; } = "";
        public string channels { get; set; } = "";
        public string blocks { get; set; } = "";
        public string additional_info { get; set; } = "";
    }

    public class Publication
    {
        public string status { get; set; } = "";
    }

}
