export interface File {
  fileName: string;
  fileSize: number;
  md5Sum?: any;
}

export interface TorrentInfo {
  originalInfoHash: string;
  originalInfoHashBytes: string;
  extraFields: ExtraFields;
  trackers: string[][];
  file: File;
  files?: any;
  fileMode: number;
  displayName: string;
  creationDate: Date;
  comment: string;
  createdBy?: any;
  encoding?: any;
  pieceSize: number;
  pieces: string;
  piecesAsHexString: string;
  isPrivate: boolean;
  totalSize: number;
  numberOfPieces: number;
}

export interface ExtraFields {}
