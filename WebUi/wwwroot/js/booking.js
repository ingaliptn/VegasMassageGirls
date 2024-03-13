/* 
 *	Project: Simple Math Captcha 
 *	Author: Laith Sinawi
 *	Author website: Website: http://www.SinawiWebDesign.com
 *  	Purpose: Client-side form validation including custom Captcha
 */

$(document).ready( function() {
$('input[placeholder], textarea[placeholder]').placeholder();
	$('#submit').removeAttr('disabled');
	
	$.validator.addMethod('captcha',
							function(value) {
								$result = ( parseInt($('#num1').val()) + parseInt($('#num2').val()) == parseInt($('#captcha').val()) ) ;
								$('#spambot').fadeOut('fast');
								return $result;
								//alert("Result is " + $result );
							},
							'Incorrect value, please try again.'
	);
	
	$('#booking').validate({
		debug: true,
		//submitHandler: ajaxSubmit
                rules: {
                    message: {
                        required: true,
                        minlength: 10,
                        maxlength: 255
                    },
					captcha: {
						required: true,
						captcha: true
					}
                },
                messages: {
                    firstname: "First name field required.",
                    lastname: "Last name field required.",
					hotelname: "Hotel name field required.",
					hotelroom: "Hotel room number field required.",
                    email: {
                        required: "Email address required",
                        email: "Email address must be in the format name@domain.com."                        
                    },
                   // message: {
                    //    required: "Message field required",
                     //   minlength: "Message must contain at least 10 characters.",
                     //   maxlength: "Message must not contain more than 255 characters."
                    //},
					chkCaptcha: {
						required: "* Required"
					}
                    
                }
                
	});
	
	$('#submit').click( function() {
		if( $('#contact').valid() ) {
				ajaxSubmit();
		}
		else {
			$('label.error').hide().fadeIn('slow');
		}
	});
	
});

function ajaxSubmit() {
	$('#loading').show();
	$('#submit').attr('disabled', 'disabled');
	var firstname = $('#firstname').val();
	var lastname = $('#lastname').val();
	var hotelname = $('#hotelname').val();
	var hotelroom = $('#hotelroom').val();
	var email = $('#email').val();
/*	var message = $('#message').val(); */
	/*alert( "Form's about to be submitted! \n" 
		+ firstName + "\n" 
		+ lastName + "\n" 
		+ email + "\n" 
		+ message + "\n" );*/
	
	var data = 'firstname=' +firstname+ '&lastname=' +lastname+ '&hotelname=' +hotelname+ '&hotelroom=' +hotelroom+ '&email=' +email;
		
	$.ajax({
		url: 'send_booking.php',
		type: 'get',
		dataType: 'json',
		data: data,
		cache: false,
		success: function(response) {
			if( response.error != 'true' ) {
				$('#loading, #booking, .message').fadeOut('slow');
				$('#response').html('<h3>Message sent successfully!</h3>').fadeIn('slow');
            }
			else {
					$('#loading').fadeOut('slow');
					$('#submit').attr('disabled', 'disabled');
					$('#response').html('<h3>There was a problem sending mail!</h3>').fadeIn('slow');
			}
		},
		error: function(jqXHR, textStatus, errorThrown) {
                                $('#loading').fadeOut('slow');
				$('#submit').removeAttr('disabled');
				$('#response').text('Error Thrown: ' +errorThrown+ '<br>jqXHR: ' +jqXHR+ '<br>textStatus: ' +textStatus ).show();
		}
	});
	return false;
}
