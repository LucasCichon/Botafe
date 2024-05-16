export function showPrompt(message) {
    return prompt(message, 'Type anything here');
}

export function alertTitle() {
    var title = $("#myTitle").val();
    alert("the title is :" + title);
}

export function init() {
    $("#hideBtn").click(function () {
        alert(1);
        $(this).hide();
    });
}