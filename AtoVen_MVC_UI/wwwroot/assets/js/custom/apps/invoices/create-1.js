"use strict";
// Add row
var row = 1;
$(document).on("click", "#add-row", function () {

	//Adding New tr
	var new_row = '<tr id="row' + row + '" class="border-bottom border-bottom-dashed">'

	//Adding first td for elements
	new_row = new_row + '<td class="pe-7">'

	//Adding DIV ROW
	new_row = new_row + '<div class="row gx-10 mb-5">'

	//Adding first col-6 
	new_row = new_row + '<div class="col-lg-6">'

	//Adding Fields
	new_row = new_row + '<div class="form-floating mb-5"><input type="text" class="form-control mb-2 border" name="firstname' + row + '" placeholder="First Name" autocomplete="off" /><label for="firstname' + row + '">First Name</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="lastname' + row + '" placeholder="Last Name" autocomplete="off" /><label for="lastname' + row + '">Last Name</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="cp_address' + row + '" placeholder="Form of Address" autocomplete="off" /><label for="cp_address' + row + '">Form of Address</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="position' + row + '" placeholder="Position" autocomplete="off" /><label for="position' + row + '">Position</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="department' + row + '" placeholder="Department" autocomplete="off" /><label for="department' + row + '">Department</label></div>'

	new_row = new_row + '</div>'
	//Closing first col-6

	//Adding first col-6 
	new_row = new_row + '<div class="col-lg-6">'

	//Adding Fields
	new_row = new_row + '<div class="form-floating mb-5"><input type="text" class="form-control border" name="cp_phoneno' + row + '" placeholder="Phone No." autocomplete="off" /><label for="cp_phoneno' + row + '">Phone No.</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="cp_faxno' + row + '" placeholder="Fax No." autocomplete="off" /><label for="cp_faxno' + row + '">Fax No.</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="cp_emil' + row + '" placeholder="E-Mail Address" autocomplete="off" /><label for="cp_emil' + row + '">E-Mail Address</label></div><div class="form-floating mb-5"><input type="text" class="form-control border" name="cp_language' + row + '" placeholder="Language" value="EN" readonly /><label for="cp_language' + row + '">language</label></div><div class="form-floating mb-5"><select class=" form-control border"  name="cp_country' + row + '" required>'

	new_row = new_row + '<option value="" selected>--select--</option><option value="1">Afghanistan</option><option value="2">�land Islands</option><option value="3">Albania</option><option value="4">Algeria</option><option value="5">American Samoa</option><option value="6">Andorra</option><option value="7">Angola</option><option value="8">Anguilla</option><option value="9">Antarctica</option><option value="10">Antigua and Barbuda</option><option value="11">Argentina</option><option value="12">Armenia</option><option value="13">Aruba</option><option value="14">Australia</option><option value="15">Austria</option><option value="16">Azerbaijan</option><option value="17">Bahamas</option><option value="18">Bahrain</option><option value="19">Bangladesh</option><option value="20">Barbados</option><option value="21">Belarus</option><option value="22">Belgium</option><option value="23">Belize</option><option value="24">Benin</option><option value="25">Bermuda</option><option value="26">Bhutan</option><option value="27">Bolivia, Plurinational State of</option><option value="28">Bonaire, Sint Eustatius and Saba</option><option value="29">Bosnia and Herzegovina</option><option value="30">Botswana</option><option value="31">Bouvet Island</option><option value="32">Brazil</option><option value="33">British Indian Ocean Territory</option><option value="34">Brunei Darussalam</option><option value="35">Bulgaria</option><option value="36">Burkina Faso</option><option value="37">Burundi</option><option value="38">Cambodia</option><option value="39">Cameroon</option><option value="40">Canada</option><option value="41">Cape Verde</option><option value="42">Cayman Islands</option><option value="43">Central African Republic</option><option value="44">Chad</option><option value="45">Chile</option><option value="46">China</option><option value="47">Christmas Island</option><option value="48">Cocos (Keeling) Islands</option><option value="49">Colombia</option><option value="50">Comoros</option><option value="51">Congo</option><option value="52">Congo, the Democratic Republic of the</option><option value="53">Cook Islands</option><option value="54">Costa Rica</option><option value="55">C�te d&#039;Ivoire</option><option value="56">Croatia</option><option value="57">Cuba</option><option value="58">Cura�ao</option><option value="59">Cyprus</option><option value="60">Czech Republic</option><option value="61">Denmark</option><option value="62">Djibouti</option><option value="63">Dominica</option><option value="64">Dominican Republic</option><option value="65">Ecuador</option><option value="66">Egypt</option><option value="67">El Salvador</option><option value="68">Equatorial Guinea</option><option value="69">Eritrea</option><option value="70">Estonia</option><option value="71">Ethiopia</option><option value="72">Falkland Islands (Malvinas)</option><option value="73">Faroe Islands</option><option value="74">Fiji</option><option value="75">Finland</option><option value="76">France</option><option value="77">French Guiana</option><option value="78">French Polynesia</option><option value="79">French Southern Territories</option><option value="80">Gabon</option><option value="81">Gambia</option><option value="82">Georgia</option><option value="83">Germany</option><option value="84">Ghana</option><option value="85">Gibraltar</option><option value="86">Greece</option><option value="87">Greenland</option><option value="88">Grenada</option><option value="89">Guadeloupe</option><option value="90">Guam</option><option value="91">Guatemala</option><option value="92">Guernsey</option><option value="93">Guinea</option><option value="94">Guinea-Bissau</option><option value="95">Guyana</option><option value="96">Haiti</option><option value="97">Heard Island and McDonald Mcdonald Islands</option><option value="98">Holy See (Vatican City State)</option><option value="99">Honduras</option><option value="100">Hong Kong</option><option value="101">Hungary</option><option value="102">Iceland</option><option value="103">India</option><option value="104">Indonesia</option><option value="105">Iran, Islamic Republic of</option><option value="106">Iraq</option><option value="107">Ireland</option><option value="108">Isle of Man</option><option value="109">Israel</option><option value="110">Italy</option><option value="111">Jamaica</option><option value="112">Japan</option><option value="113">Jersey</option><option value="114">Jordan</option><option value="115">Kazakhstan</option><option value="116">Kenya</option><option value="117">Kiribati</option><option value="118">Korea, Democratic People&#039;s Republic of</option><option value="119">Korea, Republic of</option><option value="120">Kuwait</option><option value="121">Kyrgyzstan</option><option value="122">Lao People&#039;s Democratic Republic</option><option value="123">Latvia</option><option value="124">Lebanon</option><option value="125">Lesotho</option><option value="126">Liberia</option><option value="127">Libya</option><option value="128">Liechtenstein</option><option value="129">Lithuania</option><option value="130">Luxembourg</option><option value="131">Macao</option><option value="132">Macedonia, the Former Yugoslav Republic of</option><option value="133">Madagascar</option><option value="134">Malawi</option><option value="135">Malaysia</option><option value="136">Maldives</option><option value="137">Mali</option><option value="138">Malta</option><option value="139">Marshall Islands</option><option value="140">Martinique</option><option value="141">Mauritania</option><option value="142">Mauritius</option><option value="143">Mayotte</option><option value="144">Mexico</option><option value="145">Micronesia, Federated States of</option><option value="146">Moldova, Republic of</option><option value="147">Monaco</option><option value="148">Mongolia</option><option value="149">Montenegro</option><option value="150">Montserrat</option><option value="151">Morocco</option><option value="152">Mozambique</option><option value="153">Myanmar</option><option value="154">Namibia</option><option value="155">Nauru</option><option value="156">Nepal</option><option value="157">Netherlands</option><option value="158">New Caledonia</option><option value="159">New Zealand</option><option value="160">Nicaragua</option><option value="161">Niger</option><option value="162">Nigeria</option><option value="163">Niue</option><option value="164">Norfolk Island</option><option value="165">Northern Mariana Islands</option><option value="166">Norway</option><option value="167">Oman</option><option value="168">Pakistan</option><option value="169">Palau</option><option value="170">Palestine, State of</option><option value="171">Panama</option><option value="172">Papua New Guinea</option><option value="173">Paraguay</option><option value="174">Peru</option><option value="175">Philippines</option><option value="176">Pitcairn</option><option value="177">Poland</option><option value="178">Portugal</option><option value="179">Puerto Rico</option><option value="180">Qatar</option><option value="181">R�union</option><option value="182">Romania</option><option value="183">Russian Federation</option><option value="184">Rwanda</option><option value="185">Saint Barth�lemy</option><option value="186">Saint Helena, Ascension and Tristan da Cunha</option><option value="187">Saint Kitts and Nevis</option><option value="188">Saint Lucia</option><option value="189">Saint Martin (French part)</option><option value="190">Saint Pierre and Miquelon</option><option value="191">Saint Vincent and the Grenadines</option><option value="192">Samoa</option><option value="193">San Marino</option><option value="194">Sao Tome and Principe</option><option value="195">Saudi Arabia</option><option value="196">Senegal</option><option value="197">Serbia</option><option value="198">Seychelles</option><option value="199">Sierra Leone</option><option value="200">Singapore</option><option value="201">Sint Maarten (Dutch part)</option><option value="202">Slovakia</option><option value="203">Slovenia</option><option value="204">Solomon Islands</option><option value="205">Somalia</option><option value="206">South Africa</option><option value="207">South Georgia and the South Sandwich Islands</option><option value="208">South Sudan</option><option value="209">Spain</option><option value="210">Sri Lanka</option><option value="211">Sudan</option><option value="212">Suriname</option><option value="213">Svalbard and Jan Mayen</option><option value="214">Swaziland</option><option value="215">Sweden</option><option value="216">Switzerland</option><option value="217">Syrian Arab Republic</option><option value="218">Taiwan</option><option value="219">Tajikistan</option><option value="220">Tanzania, United Republic of</option><option value="221">Thailand</option><option value="222">Timor-Leste</option><option value="223">Togo</option><option value="224">Tokelau</option><option value="225">Tonga</option><option value="226">Trinidad and Tobago</option><option value="227">Tunisia</option><option value="228">Turkey</option><option value="229">Turkmenistan</option><option value="230">Turks and Caicos Islands</option><option value="231">Tuvalu</option><option value="232">Uganda</option><option value="233">Ukraine</option><option value="234">United Arab Emirates</option><option value="235">United Kingdom</option><option value="236">United States</option><option value="237">United States Minor OutSying Islands</option><option value="238">Uruguay</option><option value="239">Uzbekistan</option><option value="240">Vanuatu</option><option value="241">Venezuela, Bolivarian Republic of</option><option value="242">Viet Nam</option><option value="243">Virgin Islands, British</option><option value="244">Virgin Islands, U.S.</option><option value="245">Wallis and Futuna</option><option value="246">Western Sahara</option><option value="247">Yemen</option><option value="248">Zambia</option><option value="249">Zimbabwe</option></select><label for="cp_country' + row + '">Country</label>'
	new_row = new_row + '</div>'

	new_row = new_row + '</div>'
	//Closing first col-6

	new_row = new_row + '</div>'
	//Closing DIV ROW

	new_row = new_row + '</td>'

	new_row = new_row + '<td class="pt-5 text-end"> <button type="button" class="btn btn-sm btn-icon btn-active-color-primary remove-item"><span class="svg-icon svg-icon-3"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none"><path d="M5 9C5 8.44772 5.44772 8 6 8H18C18.5523 8 19 8.44772 19 9V18C19 19.6569 17.6569 21 16 21H8C6.34315 21 5 19.6569 5 18V9Z" fill="black" /><path opacity="0.5" d="M5 5C5 4.44772 5.44772 4 6 4H18C18.5523 4 19 4.44772 19 5V5C19 5.55228 18.5523 6 18 6H6C5.44772 6 5 5.55228 5 5V5Z" fill="black" /><path opacity="0.5" d="M9 4C9 3.44772 9.44772 3 10 3H14C14.5523 3 15 3.44772 15 4V4H9V4Z" fill="black" /></svg></span></button></td>'

	new_row = new_row + '</tr>';


	$('#contact-person-body').append(new_row);
	row++;
	return false;
});

// Remove criterion
$(document).on("click", ".remove-item", function () {
	//  alert("deleting row#"+row);
	if (row > 1) {
		$(this).closest('tr').remove();
		row--;
	}
	return false;
});


//Bank Details 
// Add row
var rowBD = 1;
$(document).on("click", "#add-row-bank", function () {

	//Adding New tr
	var new_row_bd = '<tr id="rowBD' + rowBD + '" class="border-bottom border-bottom-dashed">'

	//Adding first td for elements
	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<select class=" form-control border"  name="bd_country' + rowBD + '" required>'
	new_row_bd = new_row_bd + '<option value="">Select Country</option><option value="1">Afghanistan</option><option value="2">�land Islands</option><option value="3">Albania</option><option value="4">Algeria</option><option value="5">American Samoa</option><option value="6">Andorra</option><option value="7">Angola</option><option value="8">Anguilla</option><option value="9">Antarctica</option><option value="10">Antigua and Barbuda</option><option value="11">Argentina</option><option value="12">Armenia</option><option value="13">Aruba</option><option value="14">Australia</option><option value="15">Austria</option><option value="16">Azerbaijan</option><option value="17">Bahamas</option><option value="18">Bahrain</option><option value="19">Bangladesh</option><option value="20">Barbados</option><option value="21">Belarus</option><option value="22">Belgium</option><option value="23">Belize</option><option value="24">Benin</option><option value="25">Bermuda</option><option value="26">Bhutan</option><option value="27">Bolivia, Plurinational State of</option><option value="28">Bonaire, Sint Eustatius and Saba</option><option value="29">Bosnia and Herzegovina</option><option value="30">Botswana</option><option value="31">Bouvet Island</option><option value="32">Brazil</option><option value="33">British Indian Ocean Territory</option><option value="34">Brunei Darussalam</option><option value="35">Bulgaria</option><option value="36">Burkina Faso</option><option value="37">Burundi</option><option value="38">Cambodia</option><option value="39">Cameroon</option><option value="40">Canada</option><option value="41">Cape Verde</option><option value="42">Cayman Islands</option><option value="43">Central African Republic</option><option value="44">Chad</option><option value="45">Chile</option><option value="46">China</option><option value="47">Christmas Island</option><option value="48">Cocos (Keeling) Islands</option><option value="49">Colombia</option><option value="50">Comoros</option><option value="51">Congo</option><option value="52">Congo, the Democratic Republic of the</option><option value="53">Cook Islands</option><option value="54">Costa Rica</option><option value="55">C�te d&#039;Ivoire</option><option value="56">Croatia</option><option value="57">Cuba</option><option value="58">Cura�ao</option><option value="59">Cyprus</option><option value="60">Czech Republic</option><option value="61">Denmark</option><option value="62">Djibouti</option><option value="63">Dominica</option><option value="64">Dominican Republic</option><option value="65">Ecuador</option><option value="66">Egypt</option><option value="67">El Salvador</option><option value="68">Equatorial Guinea</option><option value="69">Eritrea</option><option value="70">Estonia</option><option value="71">Ethiopia</option><option value="72">Falkland Islands (Malvinas)</option><option value="73">Faroe Islands</option><option value="74">Fiji</option><option value="75">Finland</option><option value="76">France</option><option value="77">French Guiana</option><option value="78">French Polynesia</option><option value="79">French Southern Territories</option><option value="80">Gabon</option><option value="81">Gambia</option><option value="82">Georgia</option><option value="83">Germany</option><option value="84">Ghana</option><option value="85">Gibraltar</option><option value="86">Greece</option><option value="87">Greenland</option><option value="88">Grenada</option><option value="89">Guadeloupe</option><option value="90">Guam</option><option value="91">Guatemala</option><option value="92">Guernsey</option><option value="93">Guinea</option><option value="94">Guinea-Bissau</option><option value="95">Guyana</option><option value="96">Haiti</option><option value="97">Heard Island and McDonald Mcdonald Islands</option><option value="98">Holy See (Vatican City State)</option><option value="99">Honduras</option><option value="100">Hong Kong</option><option value="101">Hungary</option><option value="102">Iceland</option><option value="103">India</option><option value="104">Indonesia</option><option value="105">Iran, Islamic Republic of</option><option value="106">Iraq</option><option value="107">Ireland</option><option value="108">Isle of Man</option><option value="109">Israel</option><option value="110">Italy</option><option value="111">Jamaica</option><option value="112">Japan</option><option value="113">Jersey</option><option value="114">Jordan</option><option value="115">Kazakhstan</option><option value="116">Kenya</option><option value="117">Kiribati</option><option value="118">Korea, Democratic People&#039;s Republic of</option><option value="119">Korea, Republic of</option><option value="120">Kuwait</option><option value="121">Kyrgyzstan</option><option value="122">Lao People&#039;s Democratic Republic</option><option value="123">Latvia</option><option value="124">Lebanon</option><option value="125">Lesotho</option><option value="126">Liberia</option><option value="127">Libya</option><option value="128">Liechtenstein</option><option value="129">Lithuania</option><option value="130">Luxembourg</option><option value="131">Macao</option><option value="132">Macedonia, the Former Yugoslav Republic of</option><option value="133">Madagascar</option><option value="134">Malawi</option><option value="135">Malaysia</option><option value="136">Maldives</option><option value="137">Mali</option><option value="138">Malta</option><option value="139">Marshall Islands</option><option value="140">Martinique</option><option value="141">Mauritania</option><option value="142">Mauritius</option><option value="143">Mayotte</option><option value="144">Mexico</option><option value="145">Micronesia, Federated States of</option><option value="146">Moldova, Republic of</option><option value="147">Monaco</option><option value="148">Mongolia</option><option value="149">Montenegro</option><option value="150">Montserrat</option><option value="151">Morocco</option><option value="152">Mozambique</option><option value="153">Myanmar</option><option value="154">Namibia</option><option value="155">Nauru</option><option value="156">Nepal</option><option value="157">Netherlands</option><option value="158">New Caledonia</option><option value="159">New Zealand</option><option value="160">Nicaragua</option><option value="161">Niger</option><option value="162">Nigeria</option><option value="163">Niue</option><option value="164">Norfolk Island</option><option value="165">Northern Mariana Islands</option><option value="166">Norway</option><option value="167">Oman</option><option value="168">Pakistan</option><option value="169">Palau</option><option value="170">Palestine, State of</option><option value="171">Panama</option><option value="172">Papua New Guinea</option><option value="173">Paraguay</option><option value="174">Peru</option><option value="175">Philippines</option><option value="176">Pitcairn</option><option value="177">Poland</option><option value="178">Portugal</option><option value="179">Puerto Rico</option><option value="180">Qatar</option><option value="181">R�union</option><option value="182">Romania</option><option value="183">Russian Federation</option><option value="184">Rwanda</option><option value="185">Saint Barth�lemy</option><option value="186">Saint Helena, Ascension and Tristan da Cunha</option><option value="187">Saint Kitts and Nevis</option><option value="188">Saint Lucia</option><option value="189">Saint Martin (French part)</option><option value="190">Saint Pierre and Miquelon</option><option value="191">Saint Vincent and the Grenadines</option><option value="192">Samoa</option><option value="193">San Marino</option><option value="194">Sao Tome and Principe</option><option value="195">Saudi Arabia</option><option value="196">Senegal</option><option value="197">Serbia</option><option value="198">Seychelles</option><option value="199">Sierra Leone</option><option value="200">Singapore</option><option value="201">Sint Maarten (Dutch part)</option><option value="202">Slovakia</option><option value="203">Slovenia</option><option value="204">Solomon Islands</option><option value="205">Somalia</option><option value="206">South Africa</option><option value="207">South Georgia and the South Sandwich Islands</option><option value="208">South Sudan</option><option value="209">Spain</option><option value="210">Sri Lanka</option><option value="211">Sudan</option><option value="212">Suriname</option><option value="213">Svalbard and Jan Mayen</option><option value="214">Swaziland</option><option value="215">Sweden</option><option value="216">Switzerland</option><option value="217">Syrian Arab Republic</option><option value="218">Taiwan</option><option value="219">Tajikistan</option><option value="220">Tanzania, United Republic of</option><option value="221">Thailand</option><option value="222">Timor-Leste</option><option value="223">Togo</option><option value="224">Tokelau</option><option value="225">Tonga</option><option value="226">Trinidad and Tobago</option><option value="227">Tunisia</option><option value="228">Turkey</option><option value="229">Turkmenistan</option><option value="230">Turks and Caicos Islands</option><option value="231">Tuvalu</option><option value="232">Uganda</option><option value="233">Ukraine</option><option value="234">United Arab Emirates</option><option value="235">United Kingdom</option><option value="236">United States</option><option value="237">United States Minor OutSying Islands</option><option value="238">Uruguay</option><option value="239">Uzbekistan</option><option value="240">Vanuatu</option><option value="241">Venezuela, Bolivarian Republic of</option><option value="242">Viet Nam</option><option value="243">Virgin Islands, British</option><option value="244">Virgin Islands, U.S.</option><option value="245">Wallis and Futuna</option><option value="246">Western Sahara</option><option value="247">Yemen</option><option value="248">Zambia</option><option value="249">Zimbabwe</option></select>'
	new_row_bd = new_row_bd + '</td>'

	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<input class="form-control border" type="text" name="bank_key' + rowBD + '" placeholder="" value=""/>'
	new_row_bd = new_row_bd + '</td>'

	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<input class="form-control border" type="text" name="bank_name' + rowBD + '" placeholder="" value=""/>'
	new_row_bd = new_row_bd + '</td>'

	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<input class="form-control border" type="text" name="swift_code' + rowBD + '" placeholder="" value=""/>'
	new_row_bd = new_row_bd + '</td>'

	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<input class="form-control border" type="text" name="bank_account' + rowBD + '" placeholder="" value=""/>'
	new_row_bd = new_row_bd + '</td>'

	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<input class="form-control border" type="text" name="account_holder' + rowBD + '" placeholder="" value=""/>'
	new_row_bd = new_row_bd + '</td>'

	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<input class="form-control border" type="text" name="iban' + rowBD + '" placeholder="" value=""/>'
	new_row_bd = new_row_bd + '</td>'


	new_row_bd = new_row_bd + '<td>'
	new_row_bd = new_row_bd + '<select class="form-control border"  name="bd_currency' + rowBD + '" required><option value="USD">USD</option><option value="AED">AED</option><option value="SAR">SAR</option><option value="GBP">GBP</option></select>'
	new_row_bd = new_row_bd + '</td>'


	new_row_bd = new_row_bd + '<td class="pt-5 text-end"> <button type="button" class="btn btn-sm btn-icon btn-active-color-primary remove-item-bd"><span class="svg-icon svg-icon-3"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none"><path d="M5 9C5 8.44772 5.44772 8 6 8H18C18.5523 8 19 8.44772 19 9V18C19 19.6569 17.6569 21 16 21H8C6.34315 21 5 19.6569 5 18V9Z" fill="black" /><path opacity="0.5" d="M5 5C5 4.44772 5.44772 4 6 4H18C18.5523 4 19 4.44772 19 5V5C19 5.55228 18.5523 6 18 6H6C5.44772 6 5 5.55228 5 5V5Z" fill="black" /><path opacity="0.5" d="M9 4C9 3.44772 9.44772 3 10 3H14C14.5523 3 15 3.44772 15 4V4H9V4Z" fill="black" /></svg></span></button></td>'

	new_row_bd = new_row_bd + '</tr>';


	$('#bank_dtls').append(new_row_bd);
	rowBD++;
	return false;
});

// Remove criterion
$(document).on("click", ".remove-item-bd", function () {
	//  alert("deleting row#"+row);
	if (rowBD > 1) {
		$(this).closest('tr').remove();
		rowBD--;
	}
	return false;
});

