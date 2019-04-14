/*
 Navicat Premium Data Transfer

 Source Server         : hululu
 Source Server Type    : MySQL
 Source Server Version : 80015
 Source Host           : localhost:3306
 Source Schema         : mytest

 Target Server Type    : MySQL
 Target Server Version : 80015
 File Encoding         : 65001

 Date: 09/04/2019 22:53:31
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for vote
-- ----------------------------
DROP TABLE IF EXISTS `vote`;
CREATE TABLE `vote`  (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `A` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `B` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `C` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `D` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `description` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Acount` int(100) NOT NULL DEFAULT 0,
  `Bcount` int(100) NOT NULL DEFAULT 0,
  `Ccount` int(100) NOT NULL DEFAULT 0,
  `Dcount` int(100) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of vote
-- ----------------------------
INSERT INTO `vote` VALUES (1, '周杰伦', '张学友', '张国荣', '张雨生', '你最喜欢的歌手是?', 12, 2, 0, 1);
INSERT INTO `vote` VALUES (2, '曹操', '刘备', '诸葛亮', '关羽', '你最喜欢的三国角色', 4, 2, 0, 0);
INSERT INTO `vote` VALUES (3, '数学', '语文', '英语', '物理', '你最擅长的科目', 1, 0, 1, 1);
INSERT INTO `vote` VALUES (4, '唱歌', '跳舞', '睡觉', '玩', '你最喜欢干的事', 0, 0, 1, 0);
INSERT INTO `vote` VALUES (5, '高数', '线代', '大物', '算法', '你看到哪个最头疼', 2, 0, 0, 0);
INSERT INTO `vote` VALUES (18, 'dsadsads', 'dsadsad', 'dasdsad', 'sadsadsad', 'dsadsdsads', 0, 0, 0, 0);

SET FOREIGN_KEY_CHECKS = 1;
