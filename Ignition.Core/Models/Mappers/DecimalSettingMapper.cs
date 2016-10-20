﻿using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Models.BaseModels;
using Ignition.Foundation.Core.Models.Settings;

namespace Ignition.Foundation.Core.Models.Mappers
{
	public class DecimalSettingMapper : SitecoreGlassMap<IDecimalSetting>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				ImportMap<IModelBase>();
				x.TemplateId(SettingsFactory.GetAppSetting("Ignition.Map.Id.DecimalSetting"));
				x.Field(a => a.DecimalSetting)
					.FieldId(SettingsFactory.GetAppSetting("Models.Fields.Id.DecimalSetting.DecimalSetting"));
			});
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}
