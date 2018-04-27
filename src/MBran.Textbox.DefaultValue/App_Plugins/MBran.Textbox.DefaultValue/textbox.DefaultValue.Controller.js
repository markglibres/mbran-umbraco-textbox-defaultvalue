angular.module("umbraco").controller("MBran.Textbox.DefaultValueController", [
    "$scope",
    function ($scope) {

        initModels();

        if ($scope.model.config.showIfBlank) {

            setDefaultValue();
            $scope.$watch('scope.textValue', function (newValue, oldValue) {
                if (!newValue) setDefaultValue();
            });

        }

        function setDefaultValue() {
            if (!$scope.model.value.default) {
                angular.copy($scope.model.value.default, $scope.textValue);    
            }
        }

        function initModels() {
            if (!$scope.model.value || $scope.model.value==="") {
                $scope.model.value = {
                    default: "",
                    text: ""
                };
            }
            $scope.model.value.default = $scope.model.config.defaultValue;

        }

    }
]);