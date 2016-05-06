// http://tool.sufeinet.com/

using System;
using System.Collections.Generic;

namespace BaiduPOIFiddler
{

    public class SearchExt
    {
        public string title { get; set; }
        public string wd { get; set; }
    }

    public class PlaceInfo
    {
        public string d_activity_gwj_section { get; set; }
        public string d_brand_id_section { get; set; }
        public string d_business_id { get; set; }
        public string d_business_type { get; set; }
        public string d_cater_book_pc_section { get; set; }
        public string d_cater_book_wap_section { get; set; }
        public string d_cater_rating_section { get; set; }
        public string d_data_type { get; set; }
        public string d_discount2_section { get; set; }
        public string d_discount_section { get; set; }
        public string d_discount_tm2_section { get; set; }
        public string d_discount_tm_section { get; set; }
        public string d_dist { get; set; }
        public string d_filt_type_section { get; set; }
        public string d_free_section { get; set; }
        public string d_groupon_section { get; set; }
        public string d_groupon_type_section { get; set; }
        public string d_health_score_section { get; set; }
        public string d_hotel_book_pc_section { get; set; }
        public string d_hotel_book_wap_section { get; set; }
        public string d_hourly_day1_bookable_section { get; set; }
        public string d_hourly_day1_fullroom_section { get; set; }
        public string d_hourly_day1_price_section { get; set; }
        public string d_hourly_day2_bookable_section { get; set; }
        public string d_hourly_day2_fullroom_section { get; set; }
        public string d_hourly_day2_price_section { get; set; }
        public string d_hourly_day3_bookable_section { get; set; }
        public string d_hourly_day3_fullroom_section { get; set; }
        public string d_hourly_day3_price_section { get; set; }
        public string d_hourly_day4_bookable_section { get; set; }
        public string d_hourly_day4_fullroom_section { get; set; }
        public string d_hourly_day4_price_section { get; set; }
        public string d_hourly_day5_bookable_section { get; set; }
        public string d_hourly_day5_fullroom_section { get; set; }
        public string d_hourly_day5_price_section { get; set; }
        public string d_level_section { get; set; }
        public string d_lowprice_flag_section { get; set; }
        public string d_meishipaihao_section { get; set; }
        public string d_movie_book_section { get; set; }
        public string d_overall_rating_section { get; set; }
        public string d_price_section { get; set; }
        public string d_query_attr_type { get; set; }
        public string d_rebate_section { get; set; }
        public string d_sort_rule { get; set; }
        public string d_sort_type { get; set; }
        public string d_spothot_section { get; set; }
        public string d_sub_type { get; set; }
        public string d_support_imax_section { get; set; }
        public string d_tag_filter { get; set; }
        public string d_tag_info_list { get; set; }
        public string d_tag_section { get; set; }
        public string d_ticket_book_flag_section { get; set; }
        public string d_tonight_sale_flag_section { get; set; }
        public string d_total_score_section { get; set; }
        public string d_wise_price_section { get; set; }
        public IList<SearchExt> search_ext { get; set; }
    }

    public class BrandId
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class DisplayInfoCommentLabel
    {
        public string hotel { get; set; }
        public string life { get; set; }
    }

    public class Link
    {
        public string cn_name { get; set; }
        public string name { get; set; }
        public string src { get; set; }
        public string url { get; set; }
        public string url_mobilephone { get; set; }
    }

    public class Mbc
    {
        public string markv { get; set; }
    }

    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class DetailInfo
    {
        public string areaid { get; set; }
        public string comment_num { get; set; }
        public int description_flag { get; set; }
        public DisplayInfoCommentLabel display_info_comment_label { get; set; }
        public string display_info_redu { get; set; }
        public string from_pds { get; set; }
        public string image { get; set; }
        public string image_from { get; set; }
        public string image_num { get; set; }
        public IList<Link> link { get; set; }
        public Mbc mbc { get; set; }
        public string name { get; set; }
        public string overall_rating { get; set; }
        public string phone { get; set; }
        public string poi_address { get; set; }
        public Point point { get; set; }
        public string price { get; set; }
        public string price_rating { get; set; }
        public string service_rating { get; set; }
        public string shop_hours_flag { get; set; }
        public string std_tag { get; set; }
        public string tag { get; set; }
        public string technology_rating { get; set; }
        public int validate { get; set; }
        public string weighted_tag { get; set; }
    }

    public class Ext
    {
        public DetailInfo detail_info { get; set; }
        public string src_name { get; set; }
    }

    public class ImpressionTag
    {
        public string hotel { get; set; }
        public string life { get; set; }
    }

    public class Catalog
    {
        public string field_name { get; set; }
        public string priority { get; set; }
        public string uid { get; set; }
    }

    public class SourceMap
    {
        public Catalog catalog { get; set; }
    }

    public class DisplayInfo
    {
        public IList<object> catalog_fields { get; set; }
        public ImpressionTag impression_tag { get; set; }
        public string redu { get; set; }
        public SourceMap source_map { get; set; }
        public string src_name { get; set; }
    }

    public class ExtDisplay
    {
        public DisplayInfo display_info { get; set; }
    }

    public class Content
    {
        public int acc_flag { get; set; }
        public string addr { get; set; }
        public string address_norm { get; set; }
        public IList<string> alias { get; set; }
        public string aoi { get; set; }
        public int area { get; set; }
        public int biz_type { get; set; }
        public BrandId brand_id { get; set; }
        public int catalogID { get; set; }
        public IList<IList<object>> cla { get; set; }
        public int detail { get; set; }
        public int diPointX { get; set; }
        public int diPointY { get; set; }
        public int dis { get; set; }
        public int dist2route { get; set; }
        public int dist2start { get; set; }
        public Ext ext { get; set; }
        public ExtDisplay ext_display { get; set; }
        public int ext_type { get; set; }
        public int f_flag { get; set; }
        public int father_son { get; set; }
        public string flag_type { get; set; }
        public string geo { get; set; }
        public int geo_type { get; set; }
        public string indoor_pano { get; set; }
        public int ismodified { get; set; }
        public string name { get; set; }
        public string navi_x { get; set; }
        public string navi_y { get; set; }
        public string new_catalog_id { get; set; }
        public int pano { get; set; }
        public int poiType { get; set; }
        public int poi_click_num { get; set; }
        public int poi_profile { get; set; }
        public string primary_uid { get; set; }
        public int prio_flag { get; set; }
        public int route_flag { get; set; }
        public IList<object> show_tag { get; set; }
        public int status { get; set; }
        public string std_tag { get; set; }
        public string storage_src { get; set; }
        public string street_id { get; set; }
        public string tag { get; set; }
        public string tel { get; set; }
        public int ty { get; set; }
        public string uid { get; set; }
        public int view_type { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string zip { get; set; }
    }

    public class CurrentCity
    {
        public int code { get; set; }
        public string geo { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public int sup { get; set; }
        public int sup_bus { get; set; }
        public int sup_business_area { get; set; }
        public int sup_lukuang { get; set; }
        public int sup_subway { get; set; }
        public int type { get; set; }
        public string up_province_name { get; set; }
    }

    public class Param
    {
        public string ad_page_logs { get; set; }
        public string d_brand_id { get; set; }
        public string d_query_attr_type { get; set; }
        public string d_tag_info_list { get; set; }
        public int query_show_click_flag { get; set; }
        public IList<object> sample_experiment { get; set; }
        public int view_city { get; set; }
        public string baiduid { get; set; }
        public string from { get; set; }
        public string log_id { get; set; }
        public string product { get; set; }
        public string subsys { get; set; }
        public int? uniqid { get; set; }
        public string user_ip { get; set; }
    }

    public class LbsForward
    {
        public IList<Param> param { get; set; }
    }

    public class Result
    {
        public int ad_display_type { get; set; }
        public int aladdin_res_num { get; set; }
        public int aladin_query_type { get; set; }
        public int area_profile { get; set; }
        public string business_bound { get; set; }
        public int catalogID { get; set; }
        public int cmd_no { get; set; }
        public int count { get; set; }
        public int current_null { get; set; }
        public int data_security_filt_res { get; set; }
        public int db { get; set; }
        public int debug { get; set; }
        public int jump_back { get; set; }
        public int loc_attr { get; set; }
        public int op_gel { get; set; }
        public int page_num { get; set; }
        public int pattern_sign { get; set; }
        public string profile_uid { get; set; }
        public string qid { get; set; }
        public string requery { get; set; }
        public string res_bound { get; set; }
        public string res_bound_acc { get; set; }
        public int res_l { get; set; }
        public string res_x { get; set; }
        public string res_y { get; set; }
        public int result_show { get; set; }
        public string return_query { get; set; }
        public int rp_strategy { get; set; }
        public int spec_dispnum { get; set; }
        public bool spothot { get; set; }
        public int sug_index { get; set; }
        public int time { get; set; }
        public int total { get; set; }
        public int total_busline_num { get; set; }
        public int tp { get; set; }
        public int type { get; set; }
        public string wd { get; set; }
        public string wd2 { get; set; }
        public string what { get; set; }
        public string where { get; set; }
        public string uii_type { get; set; }
        public string region { get; set; }
        public string uii_qt { get; set; }
        public int login_debug { get; set; }
        public LbsForward lbs_forward { get; set; }
    }

    public class Result2
    {
        public int err_no { get; set; }
        public int ad_num { get; set; }
        public int ctrl_flag { get; set; }
        public string logs { get; set; }
    }

    public class Ext2
    {
        public int type { get; set; }
        public int pos { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }
        public string src_name { get; set; }
        public string addr { get; set; }
        public int ad_style { get; set; }
    }

    public class Ad
    {
        public Ext2 ext { get; set; }
        public string search_item_html { get; set; }
        public string search_item_css { get; set; }
        public string search_item_js { get; set; }
        public string bubble_content_html { get; set; }
        public string bubble_content_css { get; set; }
        public string bubble_content_js { get; set; }
        public string bubble_title_html { get; set; }
        public string bubble_title_css { get; set; }
        public string bubble_title_js { get; set; }
    }

    public class Damoce
    {
        public Result2 result { get; set; }
        public IList<Ad> ads { get; set; }
    }

    public class Model
    {
        public PlaceInfo place_info { get; set; }
        public IList<Content> content { get; set; }
        public CurrentCity current_city { get; set; }
        public IList<string> hot_city { get; set; }
        public Result result { get; set; }
        public Damoce damoce { get; set; }
    }

}
