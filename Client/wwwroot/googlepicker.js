

// The Browser API key obtained from the Google API Console.

// Replace with your own Browser API key, or your own key.
var developerKey = 'AIzaSyAwPqx9N3S7HTuePmZPy0gYx924vY2K9Go';

// The Client ID obtained from the Google API Console. Replace with your own Client ID.
var clientId = "319335039362-as9fivuakk44mlt0gi86ofhv31ns3mug.apps.googleusercontent.com"

// Replace with your own project number from console.developers.google.com.
// See "Project number" under "IAM & Admin" > "Settings"
var appId = "319335039362";

// Scope to use to access user's Drive items.
var scope = ['https://www.googleapis.com/auth/drive.file'];

var pickerApiLoaded = false;

// Use the Google API Loader script to load the google.picker script.
function loadPicker() {
    gapi.load('picker', { 'callback': onPickerApiLoad });
}


function onPickerApiLoad() {
    pickerApiLoaded = true;
    createPicker();
}


// Create and render a Picker object for searching images.
function createPicker(oauthtoken) {
    if (pickerApiLoaded && oauthToken) {
        var view = new google.picker.View(google.picker.ViewId.DOCS);
        view.setMimeTypes("image/png,image/jpeg,image/jpg");
        var picker = new google.picker.PickerBuilder()
            .enableFeature(google.picker.Feature.NAV_HIDDEN)
            .enableFeature(google.picker.Feature.MULTISELECT_ENABLED)
            .setAppId(appId)
            .setOAuthToken(oauthToken)
            .addView(view)
            .addView(new google.picker.DocsUploadView())
            .setDeveloperKey(developerKey)
            .setCallback(pickerCallback)
            .build();
        picker.setVisible(true);
    }
}

// A simple callback implementation.
function pickerCallback(data) {
    if (data.action == google.picker.Action.PICKED) {
        var fileId = data.docs[0].id;
        alert('The user selected: ' + fileId);
    }
}