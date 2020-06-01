using Volo.Abp.Settings;

namespace TCX.Student.Settings
{
    public class StudentSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(StudentSettings.MySetting1));
        }
    }
}
