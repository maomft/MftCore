
var CommonHelper = {
    objectifyForm: function(formArray) { //serialize data function

        var returnArray = {};
        for (var i = 0; i < formArray.length; i++) {
            returnArray[formArray[i]['name']] = formArray[i]['value'];
        }
        return returnArray;
    },
    serializeFormToObject: function($obj) {
        return CommonHelper.objectifyForm($obj.serializeArray());
    }
};