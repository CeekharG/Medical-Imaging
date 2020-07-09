# Title: Virtual simulation of Angio- and Perfusion MRI

OVERVIEW: The purpose o your project is to implement a model of tissue that
simulates angiography and perfusion and image it with contrast enhanced MRI using an
exogenous contrast agent. Assume that this agent reduces the T1 of tissue and you are
using a T1-weighted MRI protocol (so the agent will increase the signal intensity – SI- of
tissue). Figure 1 shows a model of a heart.

Phantom: Figure 1 shows the phantom that will have the following features (note that
those are simplifications of what is actually happening in the real tissue):

• The phantom does NOT move (it does not simulate cardiac beating) and will
have two compartments, one representing tissue with normal perfusion and the
other with abnormal perfusion.
• In the part with normal perfusion the blood (+ agent) enters and then leaves
without returning again.
• The part with abnormal perfusion will have two characteristics: the blood will
enter slower than in this of normal tissue and then it will come back again and
accumulate there (i.e. stay!)
• Before the injection of the contrast agent assume that the tissue has a signal of
1.0 and the background 9empty space) is 0.0 (as shown in figure 2)

Output:
• Create a movie that shows how the SI of your phantom changes in time. The
frames of this movie will be images of the phantom “taken with your scanner” at
different instances (starting from before the injection of the agent)
• Generate a graph that shows the signal intensity versus time in your three
compartments: vessel, normally and abnormally perfused tissue.
