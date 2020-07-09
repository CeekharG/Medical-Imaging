# Title: Magnetic Resonance Imaging Virtual Scanner - Contrast
• To better appreciate and compare the different modalities, in the ultrasound scanner you
will use the same phantom you used in your Assignments 1 and 2.

• Below there are some numbered questions; in your report include the corresponding
answers. You can implement this code from scratch (any language you want!) or on
Python or MATLAB.

Objective:
Implement a piece of code that simulates the operation of an MRI virtual scanner. Below there
are some numbered questions; in your report include the corresponding answers. You can
implement this code from scratch (any language you want!) or on Python or MATLAB.
Phantom-Virtual Human: This is a rectangle with a trapezoid organ inside it. Use the same
exactly phantom you used in your previous Assignments

MRI scans: Generate a Spin Echo (SE) image; adjust the acquisition parameters so you can
have high contrast between the different compartments of your virtual human.

Question-1: In this project, you want to alter contrast between the different parts of the virtual
human. (a) What are the tissue parameters and what are the scanner parameters? (b) How can
you do that with the MRI? (c) Can you do this and How about with X-rays or Ultrasound?

Question-2: How many tissue parameters are needed to be defined for this phantom to be used
in MRI SE?

Question -3: What scanner parameters need to be changed to emphasize difference between
tissue parameters?

Question-4: In your code, with what type of structures you can assign parameters to different
types of tissue?

Input to your code is:
The resolution of the image you plan generate
The specific shape and size of the virtual human and the different parameters that are needed
to calculate the MRI signal. You can use values either from the literature or your own set! But
you must be careful with the units!

Output of your code is:
The 2D NRI image of the virtual patient
Question 5: generate two graphs (1) Contrast vs. TR and (1) Contrast vs. TE.

References:
http://www.cis.rit.edu/htbooks/mri/inside.htm
http://mriquestions.com/what-is-k-space.html
