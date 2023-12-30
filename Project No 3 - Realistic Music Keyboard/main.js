document.addEventListener("DOMContentLoaded", function() {

  let main = document.querySelector('main');
  let section = document.createElement('section');
  section.id = 'keyboard-container';
  main.appendChild(section);

  let keyboard = document.getElementById('keyboard-container');

  // Creating classes and append to the parent element(keyboard)
  for (let i = 1; i <= 24; i++) {
    let div = document.createElement('div');
    div.classList.add('keys', i <= 10 ? 'black-keys' : 'white-keys');
    keyboard.appendChild(div);
  }

  // Aligning black keys horizontally
  let blackKeys = document.querySelectorAll('.black-keys');

  let gap = ['4em', '8.37em', '17.23em', '21.5em', '25.87em', '34.62em', '39em', '47.75em', '52.12em', '56.5em']; // Left gap array
  blackKeys.forEach((bKey, index) => {
    bKey.style.left = gap[index];
  })

  //Linking audio files to the click events of keys and creating on and off functions
  const path = './Resources/audio/'
  let keys = document.querySelectorAll('.keys');
  let notes = document.getElementById('notes');

  //Audio on function
  /*audio wave hide and unhide with delay*/
  const hideUnhide = () => {
    setTimeout(() => {
      document.getElementById('wave').hidden = false; //unhide wave effect

      setTimeout(() => {
        document.getElementById('wave').hidden = true; //hide wave effect
      }, 700);
    }, 1);
  };

  //function to change the notes when playing
  const changeNotes = (KeyIndx) => {
    const C = [1, 6, 11, 18];
    const D = [2, 7, 12, 19];
    const E = [13, 20];
    const F = [3, 8, 14, 21];
    const G = [4, 9, 15, 22];
    const A = [5, 10, 16, 23];
    const B = [17, 24];

    if (C.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/C.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    } else if (D.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/D.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    } else if (E.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/E.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    }  else if (F.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/F.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    }  else if (G.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/G.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    }  else if (A.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/A.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    }  else if (B.includes(KeyIndx + 1)) {
      setTimeout(() => {
        notes.src = ('./Resources/Images/notes/B.png');
        setTimeout(() => {
          notes.src = ('./Resources/Images/switch set/anotes.gif');
        }, 700);
      }, 1);
    };  
  };

  let mainAudioSaved;

  let audioStatus = 'off';
  const audioOn = () => {
    keys.forEach((key, index) => {
      key.addEventListener('click', () => {
        if (audioStatus === 'on') {
          hideUnhide();
          if (volumeBtnStatus === 0 && muteBtnState === 0) { //condition to check volume control button status
            mainAudioSaved = new Audio(`${path}key${index + 1}.mp3`);
            mainAudioSaved.play();
            if (notesPlyBtnState === 1) {
              changeNotes(index); // call note change function
            };
          } else if (volumeBtnStatus === 1 && muteBtnState === 0) {
            mainAudioSaved = new Audio(`${path}key${index + 1}.mp3`);
            mainAudioSaved.volume = 0.30;
            mainAudioSaved.play();
            if (notesPlyBtnState === 1) {
              changeNotes(index); // call note change function
            };
          } else if (volumeBtnStatus === 0 && muteBtnState === 1) {
            mainAudioSaved = new Audio(`${path}key${index + 1}.mp3`);
            mainAudioSaved.volume = 0;
            mainAudioSaved.play();
            if (notesPlyBtnState === 1) {
              changeNotes(index); // call note change function
            };
          } else if (volumeBtnStatus === 1 && muteBtnState === 1) {
            mainAudioSaved = new Audio(`${path}key${index + 1}.mp3`);
            mainAudioSaved.volume = 0;
            mainAudioSaved.play();
            if (notesPlyBtnState === 1) {
              changeNotes(index); // call note change function
            };
          }
        };
      });
    });
  };
  //Audio off function
  const audioOff = () => {
    audioStatus = 'off';
  };

  // User Guide
  let = userGuideButtonStatus = 0;
  let guide;
  let speaker = document.getElementById('speaker');
  let userGuide = document.querySelector('header div');

  const userGuideFunc = () => {
    if (userGuideButtonStatus === 0) {
      userGuideButtonStatus++;
      speaker.hidden = false;
      guide = new Audio('./Resources/User Guide/User_Guide.mp3');
      guide.play();
    } else {
      userGuideButtonStatus--;
      speaker.hidden = true;
      guide.pause();
      guide.currentTime = 0;
    }
  }
 
  userGuide.addEventListener('click', userGuideFunc);


  // declare initial status of the buttons
  let whiteKeyClrChngBtnStatus = 0;
  let pianoTypeBtnStatus = 0;
  let themeChangeBtnState = 0;
  let muteBtnState = 0;
  let notesPlyBtnState = 0;
  let volumeBtnStatus = 0;
  let MusicPlayBtnState = 0;

  //Create seperate functions for each button
  /*Function for color change button (3rd chid)*/
  let colorChangeOnOff = 'on';
  let whiteKeys = document.getElementsByClassName('white-keys');

  const addTargetColor = (event) => {// add color function 
    event.target.style.background = 'linear-gradient(to bottom, #FF90BC, #FFC0D9, #98E4FF, #B6FFFA)';
  };
  const removeAddedColor = (event) => {//remove color function 
    event.target.style.background = '';
  };
  const applyColorChangeOnHover = () => {
    
    if (colorChangeOnOff === 'on') {
      for (let i = 0; i < whiteKeys.length; i++) {
        console.log(whiteKeys[i]);
        whiteKeys[i].addEventListener('mouseover', addTargetColor);
        whiteKeys[i].addEventListener('mouseout', removeAddedColor);
      }  
    } else {
      for (let i = 0; i < whiteKeys.length; i++) {
        console.log(whiteKeys[i]);
        whiteKeys[i].removeEventListener('mouseover', addTargetColor);
        whiteKeys[i].removeEventListener('mouseout', removeAddedColor);
      };
    };
  };

  const keyColoChange = (event) => {
    const targetSwitch = event.target;
    if (whiteKeyClrChngBtnStatus === 0) {
      whiteKeyClrChngBtnStatus++;
      colorChangeOnOff = 'on'
      targetSwitch.src = ('./Resources/Images/switch set/toggle-on-54.png');
      applyColorChangeOnHover(); // call colour change function
    } else if (whiteKeyClrChngBtnStatus === 1) {
      whiteKeyClrChngBtnStatus--;
      targetSwitch.src = ('./Resources/Images/switch set/toggle-off-54.png');
      colorChangeOnOff = 'off'     
      applyColorChangeOnHover(); 
    };
  };
  /*function for piano version button (4rd child)*/
  const mainHeader = document.getElementById('main-header')
  let saveTypeChangeEvent;
  let stopExcuteTypeBtn = true;
  let typeChangeSwitchStatus = 'off';

  const typeChange = (event) => {
    saveTypeChangeEvent = event;
    const targetSwitch = event.target;
    if (pianoTypeBtnStatus === 0) {
      pianoTypeBtnStatus++;
      targetSwitch.src = ('./Resources/Images/switch set/switch-on-54.png');
      keyboard.style.backgroundColor = '#65451F';
      keyboard.style.border = 'solid #000000 5px';
      mainHeader.style.backgroundColor = '#65451F';
      mainHeader.textContent = 'Piano Version'
    } else if (pianoTypeBtnStatus === 1) {
      pianoTypeBtnStatus--;
      typeChangeSwitchStatus = 'off';
      if (stopExcuteTypeBtn) {
        targetSwitch.src = ('./Resources/Images/switch set/switch-off-54.png');
      };
      keyboard.style.backgroundColor = '';
      keyboard.style.border = '';
      mainHeader.style.backgroundColor = '';
      mainHeader.textContent = 'MINI KEYBOARD'
    };
  };
  /*function for theme change button (5th child)*/
  const bodyBeforeStyle = document.styleSheets[0].cssRules[0].style;

  let saveThemeChangeEvent;
  let ThemeChangeSwitchStatus = 'off'
  let stopExecuteThemeBtn = true;
  
  const themeChange = (event) => {
    saveThemeChangeEvent = event;
    const targetSwitch = event.target;
    if (themeChangeBtnState === 0) {
      themeChangeBtnState++;
      targetSwitch.src = ('./Resources/Images/switch set/circle-54.png');
      targetSwitch.style.transform = 'rotate(90deg)';
      bodyBeforeStyle.backgroundImage = 'url(./Resources/Images/pianoBackground.jpg)';
    } else if (themeChangeBtnState === 1) {
      themeChangeBtnState--;
      ThemeChangeSwitchStatus = 'off';
      if (stopExecuteThemeBtn) {
        targetSwitch.src = ('./Resources/Images/switch set/circle-blue-54.png');
        targetSwitch.style.transform = 'rotate(0deg)';
      };
      bodyBeforeStyle.backgroundImage = 'url(./Resources/Images/Background.jpg)';
    };
  };
  /*function for mute button (6th child)*/
  let saveMuteEvent;
  let muteSwitchStatus = 'off'
  let stopExecuteMuteBtn = true;

  const muteSound = (event) => {
    saveMuteEvent = event;
    const targetSwitch = event.target;
    if (muteBtnState === 0) {
      muteBtnState++;
      targetSwitch.src = ('./Resources/Images/switch set/select-54.png');
    } else if (muteBtnState === 1) {
      muteBtnState--;
      muteSwitchStatus = 'off';
      if (stopExecuteMuteBtn) {
        targetSwitch.src = ('./Resources/Images/switch set/active-state-54.png');
      };
    }; 
  };
  /*function for notes play button (7th child)*/
  let saveNotesEvent;
  let notesPlaySwitchStatus = 'off'
  let stopExecuteNotesPlyBtn = true;

  const notesPlay = (event) => {
    saveNotesEvent = event;
    const targetSwitch = event.target;
    if (notesPlyBtnState === 0) {
      notesPlyBtnState++;
      targetSwitch.src = ('./Resources/Images/switch set/stop-54.png');
    } else if (notesPlyBtnState === 1) {
      notesPlyBtnState--;
      notesPlaySwitchStatus = 'off'
      if (stopExecuteNotesPlyBtn) {
        targetSwitch.src = ('./Resources/Images/switch set/record-54.png');
      };
    };
  };
  /*function for volume control button (8th child)*/
  
  const volumeControl = (event) => {
    const targetSwitch = event.target;
    if (volumeBtnStatus === 0) {
      volumeBtnStatus++;
      targetSwitch.src = ('./Resources/Images/switch set/sphere-pink-54.png');
      targetSwitch.style.transform = 'rotate(180deg)';
    } else if (volumeBtnStatus === 1) {
      volumeBtnStatus--;
      targetSwitch.src = ('./Resources/Images/switch set/sphere-green-54.png');
      targetSwitch.style.transform = 'rotate(0deg)';
      audioStatus = 'on';
    };
  };
  /*function for music button (9th child)*/
  //play music function
  let count = 0;
  let audioElement;

  let saveMusicPlayEvent;
  let musicPlaySwitchStatus = 'off';
  let stopExecuteMusicPlayBtn = true;
  
  const playMusic = () => {
    if (count % 2 != 0) {
      if (count <= 5) {
        audioElement = new Audio(`./Resources/Music/${count}.mp3`);
        audioElement.play();
      } else {
        count = 1;
        audioElement = new Audio(`./Resources/Music/${count}.mp3`);
        audioElement.play();
      }
    } else { 
      audioElement.pause();
      audioElement.currentTime = 0;
    } 
  };

  const musicOnOff = (event) => {
    count++;
    saveMusicPlayEvent = event;
    const targetSwitch = event.target;
    if (MusicPlayBtnState === 0) {
      MusicPlayBtnState++;
      targetSwitch.src = ('./Resources/Images/switch set/iconiis8-audio-wave.gif');
      playMusic();
    } else if (MusicPlayBtnState === 1) {
      MusicPlayBtnState--;
      musicPlaySwitchStatus = 'off';
      targetSwitch.src = ('./Resources/Images/switch set/static-Wave.jpg'); 
      playMusic();
    };
  };

  // functions to apply and remove events in response to power on/off button   
  let countPowerOnOff = 0;

  const applyWhenOn = () => {
    //key color change button
    if (whiteKeyClrChngBtnStatus === 1) {
      colorChangeOnOff = 'on';
      applyColorChangeOnHover();
    };
    //type change button
    if (pianoTypeBtnStatus === 0 && countPowerOnOff > 1 && typeChangeSwitchStatus === 'on') {
      stopExcuteTypeBtn = true;
      saveTypeChangeEvent.target.addEventListener('click', typeChange);
      saveTypeChangeEvent.target.click();
    };
    //theme change button
    if (themeChangeBtnState === 0 && countPowerOnOff > 1 && ThemeChangeSwitchStatus === 'on') {
      stopExecuteThemeBtn = true;
      saveThemeChangeEvent.target.addEventListener('click', themeChange);
      saveThemeChangeEvent.target.click();
    }
    //theme change button
    if (muteBtnState === 0 && countPowerOnOff > 1 && muteSwitchStatus === 'on') {
      stopExecuteMuteBtn = true;
      saveMuteEvent.target.addEventListener('click', muteSound);
      saveMuteEvent.target.click();
    };
    //voice record button
    if (notesPlyBtnState === 0 && countPowerOnOff > 1 && notesPlaySwitchStatus === 'on') {
      stopExecuteNotesPlyBtn = true;
      saveNotesEvent.target.addEventListener('click', notesPlay);
      saveNotesEvent.target.click();
    };
    //voice record button
    if (MusicPlayBtnState === 0 && countPowerOnOff > 1 && musicPlaySwitchStatus === 'on') {
      stopExecuteMusicPlayBtn = true;
      saveMusicPlayEvent.target.addEventListener('click', musicOnOff);
      saveMusicPlayEvent.target.click();
    };
  };
  
  const revokeWhenOff = () => {
    //key color change button
    colorChangeOnOff = 'off';
    applyColorChangeOnHover();
    //type change button
    if (pianoTypeBtnStatus === 1) {
      stopExcuteTypeBtn = false;
      saveTypeChangeEvent.target.click();
      typeChangeSwitchStatus = 'on';
    }
    //theme change button
    if (themeChangeBtnState === 1) {
      stopExecuteThemeBtn = false;
      saveThemeChangeEvent.target.click();
      ThemeChangeSwitchStatus = 'on';
   };
   //mute button
   if (muteBtnState === 1) {
      stopExecuteMuteBtn = false;
      saveMuteEvent.target.click();
      muteSwitchStatus = 'on';
    };
    //voice record button
   if (notesPlyBtnState === 1) {
    stopExecuteNotesPlyBtn = false;
    saveNotesEvent.target.click();
    notesPlaySwitchStatus = 'on';
    };
    //Music play button
   if (MusicPlayBtnState === 1) {
    stopExecuteMusicPlayBtn = false;
    saveMusicPlayEvent.target.click();
    musicPlaySwitchStatus = 'on';
    }; 
  };

  // Assigning events to the buttons
  const switches = document.querySelectorAll('#switch-set img');
  switches.forEach((swit, index) => {

    let powerBtnState = 0;
    if (index === 1) {
      swit.addEventListener('click', () => {
        if (powerBtnState === 0) {
          powerBtnState++;
          countPowerOnOff++
          swit.src = ('./Resources/Images/switch set/onbtn.png');
          notes.hidden = false; //music note gif unhide
          audioStatus = 'on'; // turn on audio status for next play
          audioOn(); // audio turn on
          applyWhenOn();
          //set button events when power on
          switches.forEach((subSwit, ind) => {
            switch (ind) {
              case (2):
                subSwit.addEventListener('click', keyColoChange)
                break;
              case (3):
                subSwit.addEventListener('click', typeChange);
                break;
              case (4):                
                subSwit.addEventListener('click', themeChange);
                break;
              case (5):               
                subSwit.addEventListener('click', muteSound);
                break;
              case (6):                
                subSwit.addEventListener('click', notesPlay);
                break;
              case (7):               
                subSwit.addEventListener('click', volumeControl);
                break;
              case (8):               
                subSwit.addEventListener('click', musicOnOff)
                break;
            }; 
          });
        } else if (powerBtnState === 1) {
          powerBtnState--;
          countPowerOnOff++
          swit.src = ('./Resources/Images/switch set/power-off-button-54.png');
          notes.hidden = true; //music note gif hide
          audioOff(); // audio turn off
          revokeWhenOff();

          //set remove buttons events when power off
          switches.forEach((subSwit, ind) => {
            switch (ind) {
              case (2):
                subSwit.removeEventListener('click', keyColoChange);
                break;
              case (3):
                subSwit.removeEventListener('click', typeChange);
                break;
              case (4):
                subSwit.removeEventListener('click', themeChange);
                break;
              case (5):
                subSwit.removeEventListener('click', muteSound);
                break;
              case (6):
                subSwit.removeEventListener('click', notesPlay);
                break;
              case (7):
                subSwit.removeEventListener('click', volumeControl);
                break;
              case (8):
                subSwit.removeEventListener('click', musicOnOff);
                break;
            };
          });        
        };
      });
    };
  });
});
