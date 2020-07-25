using AccountPlugins.Create.PreValidation;
using AlbanianXrm.Plugins;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Models;
using System;
using Xunit;

namespace AccountPluginsTests.Create.PreValidation
{
    public class EnsureHasContactTests
    {
        [Fact]
        public void Account_should_have_a_primary_contact()
        {
            //Arrange
            var context = new XrmFakedContext();
            var target = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "AlbanianXrm"
            };
            var pluginContext = context.GetDefaultPluginContext();
            pluginContext.InputParameters.Add(PluginBase.Target, target);

            //Act
            var exception = Record.Exception(() => context.ExecutePluginWith<EnsureHasContact>(pluginContext));

            //Assert
            Assert.IsType<InvalidPluginExecutionException>(exception);
            Assert.Equal(EnsureHasContact.MustHaveContact, exception.Message);
        }

        [Fact]
        public void Account_should_have_a_name()
        {
            //Arrange
            var context = new XrmFakedContext();
            var target = new Account()
            {
                Id = Guid.NewGuid(),
                PrimaryContactId = new EntityReference(Contact.EntityLogicalName, Guid.NewGuid())
            };
            var pluginContext = context.GetDefaultPluginContext();
            pluginContext.InputParameters.Add(PluginBase.Target, target);

            //Act
            var exception = Record.Exception(() => context.ExecutePluginWith<EnsureHasContact>(pluginContext));

            //Assert
            Assert.IsType<InvalidPluginExecutionException>(exception);
            Assert.Equal(EnsureHasContact.MustHaveName, exception.Message);
        }
    }
}
