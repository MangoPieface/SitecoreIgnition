﻿using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Models.BaseModels;
using Ignition.Foundation.Core.Models.System;

namespace Ignition.Foundation.Core.Models.Mappers
{
	public class BucketMapper : SitecoreGlassMap<IBucket>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				ImportMap<IModelBase>();
				x.TemplateId(SettingsFactory.GetAppSetting("Ignition.Map.Id.Bucket"));
			});
			
			
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}