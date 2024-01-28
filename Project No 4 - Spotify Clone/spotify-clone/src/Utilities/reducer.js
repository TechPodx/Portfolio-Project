import { reducerCases } from "./Constants";

// Create the initialState and reducer function
export const initialState = {
  token: null, // This is spotify token
  playlists: [], // Initialize playlists as an empty array
  userInfo: null, // Intial value of userInfo set to null
  selectedPlaylistId: "37i9dQZF1DWYp5sAHdz27Y", 
  selectedPlaylist: null,
};

const reducer = (state, action) => {
  switch(action.type) {
    case reducerCases.SET_TOKEN: {  
      return {
        ...state,
        token: action.token,
      };
    }
    case reducerCases.SET_PLAYLISTS: {
      return {
        ...state,
        playlists: action.playlists,
      };
    }
    case reducerCases.SET_USER: {
      return {
        ...state,
        userInfo: action.userInfo,
      };
    }
    case reducerCases.SET_PAYLIST: {
      return {
        ...state,
        selectedPlaylist: action.selectedPlaylist,
      }
    }
    default: 
      return state;
  };
};

export default reducer;
