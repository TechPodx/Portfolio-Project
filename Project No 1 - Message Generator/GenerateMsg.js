document.addEventListener('DOMContentLoaded', function () {
  // Function to generate quotes
  const quotes = [
    "Ignite the fire within, and let your inner brilliance light up your path to success with the understanding that you, as much as anybody in the entire universe, deserve your love and affection.",
    "Fuel your spirit with passion, and watch as your inner self transforms challenges into triumphs, remembering that the mind is everything; what you think, you become.",
    "In the journey of self-discovery, ignite the spark that turns dreams into reality, recognizing that your work is to discover your world and then with all your heart give yourself to it.",
    "Discover the power within; igniting your inner self is the key to unlocking limitless possibilities, guided by the wisdom that the only way to do great work is to love what you do.",
    "Embrace your inner flames, for within them lies the strength to overcome any adversity, understanding that what we think, we become. All that we are arises with our thoughts.",
    "Ignite your inner self with determination, and witness the unstoppable force you become, embracing the truth that it is better to conquer yourself than to win a thousand battles. Then the victory is yours.",
    "Set your soul ablaze with purpose; the journey to ignite your inner self is a journey to fulfillment, knowing that the way is not in the sky, but in the heart.",
    "The journey of self-ignition begins with a single spark of belief in your own potential, recognizing that you can search throughout the entire universe for someone who is more deserving of your love and affection than you are yourself, and that person is not to be found anywhere.",
    "Let the flames of self-love and determination burn bright; ignite your inner self and radiate positivity, remembering that in the end, only three things matter: how much you loved, how gently you lived, and how gracefully you let go of things not meant for you.",
    "Every step forward is a spark; let the journey to ignite your inner self be your guiding light, acknowledging that the only real failure in life is not to be true to the best one knows."
  ];
  
  const getQuotes = () => {
    let randomNum = Math.floor(Math.random() * quotes.length);
    
    let randomQuote = quotes[randomNum];
    document.getElementById('text-content').textContent = `${randomQuote}`;
  }
  
  // Function to clear the display
  const clear = () => {
    document.getElementById('text-content').textContent = ``;
  }

  //Set hovering effect for display
  const display = document.getElementById('display');
  const textContentElement = document.getElementById('text-content');

  display.addEventListener('mouseover', function() {
    if (textContentElement.textContent.trim() === '') {
      display.classList.remove('no-content')
    } else {
      display.classList.add('no-content')
    }
  })

  // call events listeners
  document.getElementById('button-container').getElementsByClassName('gen')[0].addEventListener('click', getQuotes);
  document.getElementById('button-container').getElementsByClassName('clr')[0].addEventListener('click', clear);
});

