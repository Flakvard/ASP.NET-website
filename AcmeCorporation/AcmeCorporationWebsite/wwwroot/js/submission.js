function loadSubmissions(page, pageSize) {
    $.ajax({
        type: 'GET',
        url: submissionUrl, 
        data: { page: page, pageSize: pageSize },
        success: function (result) {
            renderSubmissions(result.submissions);
            renderPagination(page, pageSize, result.totalCount);
        },
        error: function (error) {
            console.error('Error fetching submissions: ' + error);
        }
    });
}

function renderSubmissions(submissions) {
    var submissionList = $('#submission-list tbody');
    submissionList.empty();
    submissions.forEach(submission => {
        var row = `<tr class="table-light">
                        <td width="25%">${submission.firstName} ${submission.lastName}</td>
                        <td width="25%">${submission.email}</td>
                        <td width="25%">${submission.productSerialNumber}</td>
                        <td width="25%">${submission.createdDateTime}</td>
                    </tr>`;
        submissionList.append(row);
    });
}
function renderPagination(page, pageSize, totalCount) {
    var totalPages = Math.ceil(totalCount / pageSize);
    var pagination = $('#pagination');
    pagination.empty();
    for (var i = 1; i <= totalPages; i++) {
        if (i === page) {
            pagination.append(`<li class="page-item active"><a class="page-link" href="#">${i}</a></li>`);
        } else {
            pagination.append(`<li class="page-item"><a class="page-link" href="#" onclick="loadSubmissions(${i}, ${pageSize})">${i}</a></li>`);
        }
    }
}

// Load initial submissions on page load
$(document).ready(function () {
    loadSubmissions(1, 10);
});