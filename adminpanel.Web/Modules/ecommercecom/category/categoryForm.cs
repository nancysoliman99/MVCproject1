using Serenity.ComponentModel;

namespace adminpanel.ecommercecom.Forms;

[FormScript("ecommercecom.category")]
[BasedOnRow(typeof(categoryRow), CheckNames = true)]
public class categoryForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
}