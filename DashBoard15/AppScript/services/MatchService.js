﻿    var matchService = ["$http", "$q",
        function ($http, $q) {
            var self = this;

            self.get = function () {
                var deferred = $q.defer();

                $http
                    .get("api/matchapi")
                    .success(function (res) {
                        deferred.resolve(res);
                    })
                    .catch(function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            };

            self.save = function (match) {
                
                var deferred = $q.defer();                
                $http
                    .post("Matches/NewMatch", angular.toJson(match))
                    .success(function (res) {
                        deferred.resolve(res);
                    })
                    .error(function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            };
        }];

    angular
        .module("appdash")
        .service("matchService", matchService);
