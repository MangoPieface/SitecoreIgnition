﻿using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Models.BaseModels;
using Ignition.Foundation.Core.Models.System;

namespace Ignition.Foundation.Core.Installers.Mappers
{
	public class DictionaryEntryMapper : SitecoreGlassMap<IDictionaryEntry>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				ImportMap<IModelBase>();
				x.TemplateId(SettingsFactory.GetAppSetting("Ignition.Map.Id.DictionaryEntry"));
				x.AutoMap().Cachable();
			});
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}