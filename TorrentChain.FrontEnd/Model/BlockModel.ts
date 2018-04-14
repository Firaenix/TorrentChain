import { TorrentInfo } from 'Model/TorrentInfo';

export interface BlockData {
  data: string;
}

export interface BlockModel {
  blockData: BlockData;
  signature?: any;
  index: number;
  timeStamp: Date;
  hash: string;
  previousHash: string;
  torrentInfo: TorrentInfo;
}
