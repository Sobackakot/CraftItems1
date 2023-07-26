mergeInto(LibraryManager.library, 
{ 
	SaveExtern: function (data) 
	{
		var save = JSON.parse(UTF8ToString(data));
		player.setData(save);
	},
	
	LoadExtern: function () 
	{
		player.getData().then(_date =>
		{
			const myJSON = JSON.stringify(_date);
			myGame.SendMessage('SaveController', 'Load', myJSON);
		})
	},
	
	ShowAdsExtern: function()
	{
		ysdk.adv.showRewardedVideo(
		{
			callbacks: 
			{
				onOpen: () => {
				  myGame.SendMessage('YandexSdk', 'Open');

				},
				onRewarded: () => {
				  myGame.SendMessage('YandexSdk', 'Reward');
				},
				onClose: () => {
					myGame.SendMessage('YandexSdk', 'CompliteAds');
				}, 
				onError: (e) => {
					myGame.SendMessage('YandexSdk', 'CompliteAds');
				}
			}
		})
	},

});