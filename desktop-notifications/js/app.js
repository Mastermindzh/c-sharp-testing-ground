window.angular.module('exampleApp', [
    'angular-web-notification'
]).controller('exampleForm', ['$scope','webNotification', function ($scope, webNotification) {
    'use strict';

    $scope.title = 'inforit';
    $scope.text = 'Notification testing';
    $scope.image = 'http://inforit.nl/Userdata/Images/IN4-Robot-Cloud-h250.png';

    $scope.options = {
      'Permission': Notification.permission,
      'Timeout': 4000
    };

    $scope.getPermission = function(){
      Notification.requestPermission().then(function(result) {
        if (result === 'denied') {
          console.log('Permission wasn\'t granted. Allow a retry.');
          return;
        }
        if (result === 'default') {
          console.log('The permission request was dismissed.');
          return;
        }
      });
    }

    $scope.functionClick = function(){
      webNotification.showNotification($scope.title, {
         body: $scope.text,
         icon: $scope.image,
         badge: $scope.image,
         sound: 'sound.mp3', // no browser support
         lang: 'en',
         dir: 'auto', // ltr or rtl
         onClick: function onNotificationClicked() {
           console.log('Function notification clicked.');
         },
         autoClose: $scope.options['Notification Timeout']
      }, function onShow(error, hide) {
         if (error) {
             window.alert('Unable to show notification: ' + error.message);
         }
      });
    };

}])
.directive('showButton', ['webNotification', function (webNotification) {
    'use strict';

    return {
        restrict: 'C',
        scope: {
            notificationTitle: '=',
            notificationText: '=',
            notificationImage: '='
        },
        link: function (scope, element) {
            element.on('click', function onClick() {
                webNotification.showNotification(scope.notificationTitle, {
                    body: scope.notificationText,
                    icon: scope.notificationImage,
                    onClick: function onNotificationClicked() {
                        console.log('Notification clicked.');
                    },
                    autoClose: 4000 //auto close the notification after 4 seconds (you can manually close it via hide function)
                }, function onShow(error, hide) {
                    if (error) {
                        window.alert('Unable to show notification: ' + error.message);
                    } else {
                        console.log('Notification Shown.');

                        setTimeout(function hideNotification() {
                            console.log('Hiding notification....');
                            hide();
                        }, 5000);
                    }
                });
            });
        }
    };
}]);
