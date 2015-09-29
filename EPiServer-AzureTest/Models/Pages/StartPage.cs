using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EPiServer_AzureTest.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "6ecf6ebc-65ca-42f9-b928-9e2cb1e7f531", Description = "The start page of the EPiServer Azure test site")]
    public class StartPage : PageData
    {
        [Display(
            Name = "Velkomsttekst",
            Order = 10,
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.LongString)]
        public virtual string WelcomeMessage { get; set; }
    }
}