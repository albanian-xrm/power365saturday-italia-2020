using Microsoft.Xrm.Sdk;
using Models;

namespace AlbanianXrm.Plugins.AccountPlugins.Create.PostOperation
{
    public class SetContactsCustomer : PluginBase
    {
        protected override void Execute(IContext context)
        {
            var account = context.GetTarget<Account>() ?? throw new InvalidPluginExecutionException(Messages.TargetMissing);
            var primaryContact = new Contact
            {
                Id = account.PrimaryContactId.Id,
                ParentCustomerId = account.ToEntityReference()
            };
            context.GetOrganizationService().Update(primaryContact);
        }
    }
}
