$(document).ready(function () {

    setDefaultDateOnLoad();

    $('#inputDate').change(function () {

        loadDatesByCurrentDate(inputDate.value)
    })
});

function setDefaultDateOnLoad() {
    var now = new Date();
    var day = ("0" + now.getDate()).slice(-2);
    var month = ("0" + (now.getMonth() + 1)).slice(-2);
    var today = now.getFullYear() + "-" + (month) + "-" + (day);
    $('#inputDate').val(today);
    loadDatesByCurrentDate(new Date());
}

function loadDatesByCurrentDate(SetDate) {
    var weekdays = new Array("Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat");
    var months = new Array("Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec");
    var currdate = new Date(SetDate);
    var startingDate = new Date(currdate);
    var endingDate = new Date(currdate);
    var month = "";
    var date = "";
    var day = "";
    var column = 1;
    var headerCellClassName = "";
    var currentDateColumn = -1;
    var toDay = new Date();
    startingDate.setDate(startingDate.getDate() - 15);
    endingDate.setDate(endingDate.getDate() + 15);

    for (pivot = startingDate; pivot <= endingDate; pivot.setDate(pivot.getDate() + 1)) {
        month = months[pivot.getMonth()];
        date = pivot.getDate();
        day = weekdays[pivot.getDay()];

        if (day == "Sat" || day == "Sun")
            headerCellClassName = "headerCellsHoliday"
        else
            headerCellClassName = "headerCells"

        setCellAttributes("cell_0," + column, month, headerCellClassName);
        setCellAttributes("cell_1," + column, date, headerCellClassName);
        setCellAttributes("cell_2," + column, day, headerCellClassName);

        if (pivot.getDate() == toDay.getDate())
            currentDateColumn = column;

        column++;
    }

    if (currentDateColumn >= 0) {
        var headerClassName = document.getElementById("cell_0," + currentDateColumn).className + "CurrentDate";
        var leaveClassName = document.getElementById("cell_3," + currentDateColumn).className + "CurrentDate";
        setStyleToHeaderRowsByAColumn(currentDateColumn, headerClassName);
        setStyleToLeaveRowsByAColumn(currentDateColumn, leaveClassName);
    }
}

function setCellAttributes(id, text, classValue) {
    var cell = document.getElementById(id);
    cell.innerHTML = text;
    cell.className = classValue;
}

function setCellStyle(id, classValue) {
    var cell = document.getElementById(id);    
    cell.className = classValue;
}

function setStyleToLeaveRowsByAColumn(column, styleName) {
    alert(styleName);
    for (rowIndex = 3; rowIndex <= 32; rowIndex++) {
        setCellStyle("cell_" + rowIndex + "," + column, styleName);
    }
}

function setStyleToHeaderRowsByAColumn(column, styleName) {
    alert(styleName);
    for (rowIndex = 0; rowIndex <= 2; rowIndex++) {
        setCellStyle("cell_" + rowIndex + "," + column, styleName);
    }
}