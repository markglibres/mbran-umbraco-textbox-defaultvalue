angular.module("umbraco")
    .controller("MBran.Textbox.DefaultValueController", 
    function ($scope) {

        var defaultVal = $scope.model.config.defaultValue;
        init();
        
        $scope.$watch('textValue', function (newValue, oldValue) {
            if ((!newValue || newValue === "") && (defaultVal !== "" || !defaultVal)) {
                $scope.textValue = $scope.model.config.defaultValue;
            } else {
                $scope.model.value = newValue;
            }
        });

        function init() {
            if (!$scope.model.value || $scope.model.value === "") {
                $scope.model.value = defaultVal;
            }
            $scope.textValue = $scope.model.value;
        }
        
});