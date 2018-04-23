using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class MyItem {
    string id;
    string contactName;
    string groupText;

    public MyItem(string id, string contactName, string groupText) {
        this.id = id;
        this.contactName = contactName;
        this.groupText = groupText;
    }
    public string ID {
        get { return id; }
    }
    public string ContactName {
        get { return contactName; }
    }
    public string GroupText {
        get { return groupText; }
    }
}


public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        ArrayList items = new ArrayList();

        IEnumerable data = AccessDataSource1.Select(new DataSourceSelectArguments());
        foreach(object item in data) {
            DataRowView row = item as DataRowView;
            string id = row["CustomerId"].ToString();
            string s = row["ContactName"].ToString().ToUpper();
            string groupText = "?";
            if(!string.IsNullOrEmpty(s)) {
                char c = s.Substring(0, 1)[0];
                if('A' <= c && c <= 'F')
                    groupText = "A-F";
                else if('G' <= c && c <= 'M')
                    groupText = "G-M";
                else if('N' <= c && c <= 'S')
                    groupText = "N-S";
                else if('T' <= c && c <= 'Z')
                    groupText = "T-Z";
            }
            items.Add(new MyItem(id, s, groupText));

        }
        
        ASPxTitleIndex1.DataSource = items;
        ASPxTitleIndex1.DataBind();
    }
}
