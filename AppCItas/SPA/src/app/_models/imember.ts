import { IPhoto } from "./iphoto";

export interface IMember {
  userName: string;
  age: number;
  gender: string;
  photoUrl: string;
  dateOfBirth: string;
  knownAs: string;
  created: string;
  lastActive: string;
  introduction: string;
  lookingFor: string;
  interests: string;
  city: string;
  country: string;
  photos: IPhoto[];
}
