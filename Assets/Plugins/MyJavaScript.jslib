mergeInto(LibraryManager.library, { 

  ShowReclama: function () {
   ysdk.adv.showRewardedVideo({
    callbacks: {
      onOpen: () => {
        console.log('Video ad open.');
        MyGameInstance.SendMessage('MainCamera', 'PouseMusic'); 
      },
      onRewarded: () => { 
        console.log('Rewarded!');
        
      },
      onClose: () => {
        console.log('Video ad closed.');
        MyGameInstance.SendMessage('MainCamera', 'PlayingMusic');
      }, 
      onError: (e) => {
        console.log('Error while open video ad:', e);
      }
    }
  })
 }, 

});
