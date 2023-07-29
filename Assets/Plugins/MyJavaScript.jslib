mergeInto(LibraryManager.library, {

  GetPlayerData: function () {
    MyGameInstance.SendMessage('Yandex', 'SetNamePlayer',player.getName());
    MyGameInstance.SendMessage('Yandex', 'SetImagePlayer',player.getPhoto("medium")); 
  },
  RateGame: function () {
    ysdk.feedback.canReview()
    .then(({ value, reason }) => {
      if (value) {
        ysdk.feedback.requestReview()
        .then(({ feedbackSent }) => {
          console.log(feedbackSent);
        })
      } else {
        console.log(reason)
      }
    }) 
  }, 
  MyLiderBoards: function (value) {
    ysdk.getLeaderboards()
    .then(lb => {  
      lb.setLeaderboardScore('NumberCraft', value);  
    });
  },

});
