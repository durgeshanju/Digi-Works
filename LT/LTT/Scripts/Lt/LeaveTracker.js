$(document).ready(function () {

    setDefaultDateOnLoad();

    $('#inputDate').change(function () {

        loadDatesByCurrentDate(inputDate.value)
    })
});

function setDefaultDateOnLoad()
{
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
    startingDate.setDate(startingDate.getDate() - 15);
    endingDate.setDate(endingDate.getDate() + 15);

    for (pivot = startingDate; pivot <= endingDate; pivot.setDate(pivot.getDate() + 1)) {
        month = months[pivot.getMonth()];
        date = pivot.getDate();
        day = weekdays[pivot.getDay()];

        if (day == "Sat" || day == "Sun")
        {
            headerCellClassName = "headerHolidayCells"
            //setHolidayLeaveCellsStyle(column);
        }
        else
            headerCellClassName = "headerCells"

        setCellAttributes("cell_0," + column, month, headerCellClassName);
        setCellAttributes("cell_1," + column, date, headerCellClassName);
        setCellAttributes("cell_2," + column, day, headerCellClassName);        

        column++;
    }

    function setCellAttributes(id, text, classValue) {
        var cell = document.getElementById(id);
        cell.innerHTML = text;
        cell.className = classValue;
    }

    function setHolidayLeaveCellsStyle(column)
    {
        var cellText = "";
        var cellId = "";
        var cellClass = "leaveHolidayCells";
        
        for (row = 3; row < 14; row++)
        {            
            cellId = "cell_" + row +"," + column;
            cellText = document.getElementById(cellId).innerHTML;
            setCellAttributes(cellId, cellText, cellClass);
        }
    }
}