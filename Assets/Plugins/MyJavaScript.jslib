mergeInto(LibraryManager.library, {

  GetPlayerData: function () {
    MyGameInstance.SendMessage('Yandex', 'SetNamePlayer',player.getName());
    MyGameInstance.SendMessage('Yandex', 'SetImagePlayer',player.getPhoto("medium")); 
  },

  
  });