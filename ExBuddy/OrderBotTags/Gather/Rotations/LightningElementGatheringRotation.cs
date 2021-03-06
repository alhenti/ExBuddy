﻿namespace ExBuddy.OrderBotTags.Gather.Rotations
{
	using Attributes;
	using ff14bot;
	using ff14bot.Managers;
	using System.Threading.Tasks;

#if RB_CN
    using ActionManager = ff14bot.Managers.Actionmanager;
#endif

	[GatheringRotation("LightningElement", 30, 400)]
	public sealed class LightningElementGatheringRotation : SmartGatheringRotation
	{
		public override async Task<bool> ExecuteRotation(ExGatherTag tag)
		{
			if (Core.Player.CurrentGP > 399)
			{
				await Wait();
				ActionManager.DoAction(219U, Core.Player);
			}

			return await base.ExecuteRotation(tag);
		}
	}
}