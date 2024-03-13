

var veags_modal_content,
vegas_modal_screen;

$(document).ready(function() {
	av_legality_check();
});


av_legality_check = function () {
    if ($.cookie('is_legal') == "yes") {
		// legal!
		// Do nothing?
	} else {
		av_showmodal();

		// Make sure the prompt stays in the middle.
		$(window).on('resize', av_positionPrompt);
	}
};

av_showmodal = function() {
	vegas_modal_screen = $('<div id="vegas_modal_screen"></div>');
	veags_modal_content = $('<div id="veags_modal_content" style="display:none"></div>');
	var veags_modal_site_content_wrapper = $('<div id="veags_modal_site_content_wrapper" class="site_content_wrapper"></div>');
	var modal_regret_wrapper = $('<div id="modal_regret_wrapper" class="site_content_wrapper" style="display:none;"></div>');

	// Question Content
	//var content_heading = $('<h2>Are you 18 or older?</h2>');
	var content_heading = $('');
	var content_heading = $('<div class="popUp_Logo"><img src="img/main_logo.png" alt="" /></div>');
	var content_buttons = $('<nav class="popup_button_group"><ul><li><a href="#nothing" class="av_btn av_go" rel="yes">ENTER</a></li><li><a href="https://www.google.com" class="av_btn2 av_no" rel="no">EXIT</a></li></ul></nav>');
	//var content_text = $('<p>You must verify that you are 18 years of age or older to enter this site.</p>');
	var content_text = $('<div class="vegas_popContent_block"><div class="model_imgBlock"><img src="img/model_img2.jpg" /></div><div class="vegas_popup_ageNotice"><p><strong class="adult_text">Adults Only!</strong></p><p>This website contains nudity, explicit sexual content and adult language.</p><p>To browse this website you must accept the following terms:</p><p>You are 18 years old or over.</p><p>You understand there will be explicit content.</p><p>The shocking content will not offend me.</p><p>VegasMassageGirls has a zero-tolerance policy toward human trafficking, prostitution, and any other illegal conduct. We cooperate with law enforcement, pursuant to appropriate process, such as a subpoena, in investigating criminal activity. Activity that violates our zero-tolerance policy may result in a referral to law enforcement. I have no intention to, and will not, use this site in violation of VegasMassageGirls’ policies or any federal, state, or local law, and I agree to report violations to the appropriate authorities.</p></div></div>');
	// Regret Content
	var regret_heading = $('<h2>We\'re Sorry!</h2>');
	var regret_buttons = $('<nav><small>I hit the wrong button!</small> <ul><li><a href="#nothing" class="av_btn av_go" rel="yes">I\'M OLD ENOUGH!</a></li></ul></nav>');
	var regret_text = $('<p>You must be 18 years of age or older to enter this site.</p>');
	

	veags_modal_site_content_wrapper.append(content_heading, content_text, content_buttons);
	modal_regret_wrapper.append(regret_heading, regret_buttons, regret_text);
	veags_modal_content.append(veags_modal_site_content_wrapper, modal_regret_wrapper);

	// Append the prompt to the end of the document
	$('body').append(vegas_modal_screen, veags_modal_content);

	// Center the box
	av_positionPrompt();

	veags_modal_content.find('a.av_btn').on('click', av_setCookie);
};

av_setCookie = function(e) {
	e.preventDefault();

	var is_legal = $(e.currentTarget).attr('rel');

	$.cookie('is_legal', is_legal, {
		expires: 30,
		path: '/'
	});

	if (is_legal == "yes") {
		av_closeModal();
		$(window).off('resize');
	} else {
		av_showRegret();
	}
};

av_closeModal = function() {
	veags_modal_content.fadeOut();
	vegas_modal_screen.fadeOut();
};

av_showRegret = function() {
	vegas_modal_screen.addClass('nope');
	veags_modal_content.find('#veags_modal_site_content_wrapper').hide();
	veags_modal_content.find('#modal_regret_wrapper').show();
};

av_positionPrompt = function() {
	var top = ($(window).outerHeight() - $('#veags_modal_content').outerHeight()) / 2;
	var left = ($(window).outerWidth() - $('#veags_modal_content').outerWidth()) / 2;
	veags_modal_content.css({
		'top': top,
		'left': left
	});

	if (veags_modal_content.is(':hidden') && ($.cookie('is_legal') != "yes")) {
		veags_modal_content.fadeIn('slow')
	}
};
