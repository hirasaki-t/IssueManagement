import { Meta, Story } from "@storybook/react/types-6-0";
import ProjectListPage from "../pages/ProjectListPage";

export default {
    title: "pages/ProjectListPage",
    components: ProjectListPage,
} as Meta;

const Template: Story = () => <ProjectListPage />;

export const Default = Template.bind({});