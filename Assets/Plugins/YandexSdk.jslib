mergeInto(LibraryManager.library, 
{ 
	SaveExten: function (data) 
	{
		var save = JSON.parse(UTF8ToString(data));
		player.setData(save);
	},
	
	LoadExten: function () 
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
				  console.log('Video ad open.');
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

}