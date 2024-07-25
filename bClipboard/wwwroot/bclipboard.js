export function copyTextToClipboard(text) {
    navigator.clipboard.writeText(text).then(function () { }).catch(function (error) { });
}

export function readTextFromClipboard() {
    return navigator.clipboard.readText().then(function (text) {
        return text;
    }).catch(function (error) { 
        return '';
    });
}