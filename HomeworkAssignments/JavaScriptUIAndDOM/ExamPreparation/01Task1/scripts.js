function createCalendar(selector, events) {
    var month, currentDay, day, week, currentWeek, i, addedDays = 1, daysInWeek = 7, weeksInMonth = 5, daysInMonth = 30,
    weekDays = ['sat', 'sun', 'mon', 'tue', 'wed', 'thu', 'fri'],
    dayHeader, currentDayHeader, eventsDictionary = [];

    day = document.createElement('div');
    week = document.createElement('div');
    month = document.createElement('div');
    dayHeader = document.createElement('h4');

    day.style.border = '1px solid #000';
    day.style.width = '160px';
    day.style.height = '150px';
    day.style.display = 'inline-block';
    week.style.display = 'inline-block';
    day.style.margin = '0';
    day.style.padding = '0';
    week.style.margin = '0';
    week.style.padding = '0';
    month.style.margin = '0';
    month.style.padding = '0';

    dayHeader.style.textAlign = 'center';
    dayHeader.style.background = '#CCC';
    dayHeader.style.margin = '0';
    dayHeader.style.borderBottom = '1px solid #000';

    // Events
    //day.addEventListener('click', function () { day.style.background = '#000'; });
    //day.onmouseout = function () { day.style.background = '#CCC' };


    for (var i = 0; i < events.length; i++) {
        eventsDictionary[events[i].date] = events[i];
    }


    for (var j = 0; j < weeksInMonth; j++) {
        currentWeek = week.cloneNode(true);

        for (i = 0; i < 7 && addedDays <= daysInMonth; i += 1) {
            currentDayHeader = dayHeader.cloneNode(true);
            currentDayHeader.textContent = weekDays[i & 7] + ' ' + (addedDays) + ' Jun 2014';

            currentDay = day.cloneNode(true)
            currentDay.addEventListener('mouseenter', function () {
                if (this.firstChild.style.background != 'none repeat scroll 0% 0% rgb(255, 255, 255)') {
                    this.firstChild.style.background = '#8A8A8A';
                }
            });

            currentDay.addEventListener('mouseleave', function () {
                if (this.firstChild.style.background != 'none repeat scroll 0% 0% rgb(255, 255, 255)') {
                    this.firstChild.style.background = '#CCC';
                }
            });

            currentDay.addEventListener('click', function () {
                //var result = [],
                //node = this.parentNode.parentNode;
                ////console.log(node);

                //while (node && node.nodeType === 1 && node !== this) {
                //    result.push(node);
                //    node = node.nextElementSibling || node.nextSibling;
                //}

                //for (var i = 0; i < result.childElementCount; i++) {
                //    console.log(result[i].firstChild);

                //    //if (result[i].firstChild.style.background == 'none repeat scroll 0% 0% rgb(255, 255, 255)') {
                //    //    result[i].firstChild.style.background == '#CCC';
                //    //}
                //}

                var calendar = document.querySelector('#calendar-container');
                var h4 = calendar.querySelectorAll('h4');

                for (var i = 0; i < h4.length; i++) {
                    h4[i].style.background = '#CCC';
                }

                this.firstChild.style.background = '#FFF';
            });

            currentDay.appendChild(currentDayHeader);

            if (eventsDictionary[addedDays]) {
                currentDayHeader = document.createElement('span');
                currentDayHeader.style.margin = '0';
                currentDayHeader.style.padding = '0';
                currentDayHeader.style.cssFloat = 'left';

                currentDayHeader.textContent = eventsDictionary[addedDays].title + ' - ' +
                    eventsDictionary[addedDays].hour + ' ' + eventsDictionary[addedDays].duration;

                currentDay.appendChild(currentDayHeader);
            }

            currentWeek.appendChild(currentDay);

            addedDays += 1;
        }

        month.appendChild(currentWeek);
    }

    document.getElementById('calendar-container').appendChild(month);


























    //var day = document.createElement('div');
    //applyDayStyles(day);

    //var week = document.createElement('div');
    //var month = generateMonth();
    //var calendar = document.querySelector(selector);
    //calendar.appendChild(month);


    //function generateMonth() {
    //    var frag = document.createDocumentFragment();

    //    for (var i = 0; i < 5; i++) {
    //        var startDay = i * 7 + 1;
    //        var endDay = startDay + 6;
    //        var currentWeek = generateWeek();
    //        frag.appendChild(currentWeek);
    //    }

    //    return frag;
    //}

    //function generateWeek(startDay, endDay) {
    //    var currentWeek = week.cloneNode(true);
    //    for (var i = startDay; i <= endDay; i++) {
    //        var currentDay = generateDay();
    //        currentWeek.appendChild(currentDay);
    //    }

    //    return currentWeek;
    //}

    //function generateDay(date) {
    //    var currentDay = day.cloneNode(true);

    //    return currentDay;
    //}

    //function applyDayStyles(day) {
    //    day.style.display = 'inline-block';
    //    day.style.width = '150px';
    //    day.style.height = '200px';
    //    day.style.border = '1px solid #000';
    //}
}